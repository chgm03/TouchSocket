//------------------------------------------------------------------------------
//  此代码版权（除特别声明或在XREF结尾的命名空间的代码）归作者本人若汝棋茗所有
//  源代码使用协议遵循本仓库的开源协议及附加协议，若本仓库没有设置，则按MIT开源协议授权
//  CSDN博客：https://blog.csdn.net/qq_40374647
//  哔哩哔哩视频：https://space.bilibili.com/94253567
//  Gitee源代码仓库：https://gitee.com/RRQM_Home
//  Github源代码仓库：https://github.com/RRQM
//  API首页：https://touchsocket.net/
//  交流QQ群：234762506
//  感谢您的下载和使用
//------------------------------------------------------------------------------

using TouchSocket.Core;

namespace TouchSocket.Dmtp;

internal enum ChannelDataType : byte
{
    DataOrder,
    CompleteOrder,
    CancelOrder,
    DisposeOrder,
    HoldOnOrder,
    QueueRun,
    QueuePause
}

internal class ChannelPackage : MsgRouterPackage
{
    public int ChannelId { get; set; }
    public ByteBlock Data { get; set; }
    public ChannelDataType DataType { get; set; }
    public bool RunNow { get; set; }

    public int GetLen()
    {
        return this.Data == null ? 1024 : this.Data.Length + 1024;
    }

    public override void PackageBody<TByteBlock>(ref TByteBlock byteBlock)
    {
        base.PackageBody(ref byteBlock);
        byteBlock.WriteBoolean(this.RunNow);
        byteBlock.WriteByte((byte)this.DataType);
        byteBlock.WriteInt32(this.ChannelId);

        byteBlock.WriteByteBlock(this.Data);
    }

    public override void UnpackageBody<TByteBlock>(ref TByteBlock byteBlock)
    {
        base.UnpackageBody(ref byteBlock);
        this.RunNow = byteBlock.ReadBoolean();
        this.DataType = (ChannelDataType)byteBlock.ReadByte();
        this.ChannelId = byteBlock.ReadInt32();
        this.Data = byteBlock.ReadByteBlock();
    }
}
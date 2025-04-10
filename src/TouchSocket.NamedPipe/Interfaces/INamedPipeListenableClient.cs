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

namespace TouchSocket.NamedPipe;

/// <summary>
/// 定义了一个接口，用于指定命名管道客户端的监听功能。
/// </summary>
public interface INamedPipeListenableClient
{
    /// <summary>
    /// 获取包含此辅助类的主服务器类。
    /// </summary>
    /// <value>主服务器类的实例。</value>
    INamedPipeServiceBase Service { get; }

    /// <summary>
    /// 获取监听配置。
    /// <para>
    /// 注意：一般情况下不要随意修改该值。
    /// </para>
    /// </summary>
    /// <value>命名管道的监听选项。</value>
    NamedPipeListenOption ListenOption { get; }
}
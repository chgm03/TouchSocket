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

namespace TouchSocket.Resources {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class TouchSocketDmtpResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TouchSocketDmtpResource() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TouchSocket.Dmtp.Resources.TouchSocketDmtpResource", typeof(TouchSocketDmtpResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 Id为{0}的通道已存在。 的本地化字符串。
        /// </summary>
        public static string ChannelExisted {
            get {
                return ResourceManager.GetString("ChannelExisted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 从‘{0}’创建写入流失败，信息：{1}。 的本地化字符串。
        /// </summary>
        public static string CreateWriteStreamFail {
            get {
                return ResourceManager.GetString("CreateWriteStreamFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 目录‘{0}’已存在。 的本地化字符串。
        /// </summary>
        public static string DirectoryExisted {
            get {
                return ResourceManager.GetString("DirectoryExisted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 目录‘{0}’不存在。 的本地化字符串。
        /// </summary>
        public static string DirectoryNotExists {
            get {
                return ResourceManager.GetString("DirectoryNotExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 DmtpFileTransferActor为空，可能需要启用DmtpFileTransfer插件。 的本地化字符串。
        /// </summary>
        public static string DmtpFileTransferActorNull {
            get {
                return ResourceManager.GetString("DmtpFileTransferActorNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 DmtpRpcActor为空，可能需要启用DmtpRpc插件。 的本地化字符串。
        /// </summary>
        public static string DmtpRpcActorArgumentNull {
            get {
                return ResourceManager.GetString("DmtpRpcActorArgumentNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 文件‘{0}’已存在。 的本地化字符串。
        /// </summary>
        public static string FileExisted {
            get {
                return ResourceManager.GetString("FileExisted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 文件长度太长。 的本地化字符串。
        /// </summary>
        public static string FileLengthTooLong {
            get {
                return ResourceManager.GetString("FileLengthTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 文件‘{0}’不存在。 的本地化字符串。
        /// </summary>
        public static string FileNotExists {
            get {
                return ResourceManager.GetString("FileNotExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 事件操作器异常。 的本地化字符串。
        /// </summary>
        public static string GetEventArgsFail {
            get {
                return ResourceManager.GetString("GetEventArgsFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 还有{0}个资源没有完成。 的本地化字符串。
        /// </summary>
        public static string HasUnFinished {
            get {
                return ResourceManager.GetString("HasUnFinished", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 读取文件长度错误。 的本地化字符串。
        /// </summary>
        public static string LengthErrorWhenRead {
            get {
                return ResourceManager.GetString("LengthErrorWhenRead", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 RedisActor为空，可能需要启用RedisActor插件。 的本地化字符串。
        /// </summary>
        public static string RedisActorNull {
            get {
                return ResourceManager.GetString("RedisActorNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 RemoteAccessActor为空，可能需要启用RemoteAccess插件。 的本地化字符串。
        /// </summary>
        public static string RemoteAccessActorNull {
            get {
                return ResourceManager.GetString("RemoteAccessActorNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 远程终端拒绝该操作，反馈信息：{0}。 的本地化字符串。
        /// </summary>
        public static string RemoteRefuse {
            get {
                return ResourceManager.GetString("RemoteRefuse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 RemoteStreamActor为空，可能需要启用RemoteStream插件。 的本地化字符串。
        /// </summary>
        public static string RemoteStreamActorNull {
            get {
                return ResourceManager.GetString("RemoteStreamActorNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 资源句柄{0}对应的资源没有找到，可能操作已超时。 的本地化字符串。
        /// </summary>
        public static string ResourceHandleNotFind {
            get {
                return ResourceManager.GetString("ResourceHandleNotFind", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 不允许路由该包，信息：{0}。 的本地化字符串。
        /// </summary>
        public static string RoutingNotAllowed {
            get {
                return ResourceManager.GetString("RoutingNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 函数执行异常，详细信息：{0}。 的本地化字符串。
        /// </summary>
        public static string RpcInvokeException {
            get {
                return ResourceManager.GetString("RpcInvokeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 方法已被禁用。 的本地化字符串。
        /// </summary>
        public static string RpcMethodDisable {
            get {
                return ResourceManager.GetString("RpcMethodDisable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 未找到该公共方法，或该方法未标记为Rpc。 的本地化字符串。
        /// </summary>
        public static string RpcMethodNotFind {
            get {
                return ResourceManager.GetString("RpcMethodNotFind", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 通道设置失败。 的本地化字符串。
        /// </summary>
        public static string SetChannelFail {
            get {
                return ResourceManager.GetString("SetChannelFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 流容器为空。 的本地化字符串。
        /// </summary>
        public static string StreamBucketNull {
            get {
                return ResourceManager.GetString("StreamBucketNull", resourceCulture);
            }
        }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repository
{
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Tip {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Tip() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Repository.Tip", typeof(Tip).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性
        ///   重写当前线程的 CurrentUICulture 属性。
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
        ///   查找类似 提交信息不完整！ 的本地化字符串。
        /// </summary>
        public static string BadRequest {
            get {
                return ResourceManager.GetString("BadRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 删除数据失败！ 的本地化字符串。
        /// </summary>
        public static string DeleteError {
            get {
                return ResourceManager.GetString("DeleteError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 该用户不可修改! 的本地化字符串。
        /// </summary>
        public static string GodUserInvaild {
            get {
                return ResourceManager.GetString("GodUserInvaild", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 插入数据库失败! 的本地化字符串。
        /// </summary>
        public static string InserError {
            get {
                return ResourceManager.GetString("InserError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 已存在! 的本地化字符串。
        /// </summary>
        public static string IsExist {
            get {
                return ResourceManager.GetString("IsExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 菜单目前最多支持2级！ 的本地化字符串。
        /// </summary>
        public static string MenuOverFlow {
            get {
                return ResourceManager.GetString("MenuOverFlow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 非法调用! 的本地化字符串。
        /// </summary>
        public static string RequestInvaild {
            get {
                return ResourceManager.GetString("RequestInvaild", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 该角色名称已存在! 的本地化字符串。
        /// </summary>
        public static string RoleNameIsExists {
            get {
                return ResourceManager.GetString("RoleNameIsExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 该角色不存在! 的本地化字符串。
        /// </summary>
        public static string RoleNotExist {
            get {
                return ResourceManager.GetString("RoleNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 意料外错误! 的本地化字符串。
        /// </summary>
        public static string SystemError {
            get {
                return ResourceManager.GetString("SystemError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 更新数据库失败! 的本地化字符串。
        /// </summary>
        public static string UpdateError {
            get {
                return ResourceManager.GetString("UpdateError", resourceCulture);
            }
        }
    }
}

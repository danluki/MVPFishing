﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fishing.BL.Resources.Paths {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ConfigPaths {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ConfigPaths() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Fishing.BL.Resources.Paths.ConfigPaths", typeof(ConfigPaths).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на config/assemblies.dat.
        /// </summary>
        internal static string ASSEMBLIES_DIR {
            get {
                return ResourceManager.GetString("ASSEMBLIES_DIR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на config/history.dat.
        /// </summary>
        internal static string EVENTHSTR_DIR {
            get {
                return ResourceManager.GetString("EVENTHSTR_DIR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на config/fishlist.dat.
        /// </summary>
        internal static string FISHLIST_DIR {
            get {
                return ResourceManager.GetString("FISHLIST_DIR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на config/flines.dat.
        /// </summary>
        internal static string FLINES_DIR {
            get {
                return ResourceManager.GetString("FLINES_DIR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на config/lures.dat.
        /// </summary>
        internal static string LURES_DIR {
            get {
                return ResourceManager.GetString("LURES_DIR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на config/money.dat.
        /// </summary>
        internal static string MONEY_DIR {
            get {
                return ResourceManager.GetString("MONEY_DIR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на config/name.dat.
        /// </summary>
        internal static string NAME_DIR {
            get {
                return ResourceManager.GetString("NAME_DIR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на config/reels.dat.
        /// </summary>
        internal static string REELS_DIR {
            get {
                return ResourceManager.GetString("REELS_DIR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на config/roads.dat.
        /// </summary>
        internal static string ROADS_DIR {
            get {
                return ResourceManager.GetString("ROADS_DIR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на config/stats.dat.
        /// </summary>
        internal static string STATS_DIR {
            get {
                return ResourceManager.GetString("STATS_DIR", resourceCulture);
            }
        }
    }
}
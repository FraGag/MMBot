﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1008
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MMBot.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MMBot.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
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
        ///   Looks up a localized string similar to [assembly:System.Security.SecurityTransparent()]
        ///public class MMBotCodeClass
        ///{
        ///    private static bool isRunning = false;
        ///    public const double e = System.Math.E;
        ///    public const double pi = System.Math.PI;
        ///    public static decimal abs(decimal value) { return System.Math.Abs(value); }
        ///    public static double abs(double value) { return System.Math.Abs(value); }
        ///    public static short abs(short value) { return System.Math.Abs(value); }
        ///    public static int abs(int value) { return System.Math.A [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Calc {
            get {
                return ResourceManager.GetString("Calc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;CommandList xmlns=&quot;http://localhost&quot;
        /// xmlns:xsi=&quot;http://www.w3.org/2001/XMLSchema-instance&quot;
        /// xsi:schemaLocation=&quot;http://localhost CommandList.xsd&quot;&gt;
        ///  &lt;BotCommand name=&quot;help&quot; functionName=&quot;HelpCommand&quot;&gt;
        ///    &lt;HelpText&gt;
        ///      &lt;![CDATA[Syntax: help &lt;u&gt;command&lt;u&gt;
        ///Displays help for a &lt;u&gt;command&lt;u&gt;.]]&gt;
        ///    &lt;/HelpText&gt;
        ///  &lt;/BotCommand&gt;
        ///  &lt;BotCommand name=&quot;nick&quot; accessLevel=&quot;BotOp&quot; functionName=&quot;NickCommand&quot; cmdMinLength=&quot;1&quot;&gt;
        ///    &lt;HelpText&gt;
        ///      &lt;![CDATA[Syntax: n [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CommandList {
            get {
                return ResourceManager.GetString("CommandList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using MMBot;
        ///
        ///public class MMBotCodeClass
        ///{
        ///	private static bool isRunning = false;
        ///	public static /*unsafe*/ object CustomCode(IRC network, IRCChannel channel)
        ///	{
        ///		if (isRunning)
        ///			return null;
        ///		isRunning = true;
        /////CODE GOES HERE;
        ///		return &quot;Done&quot;;
        ///	}
        ///}.
        /// </summary>
        internal static string MyC_Code {
            get {
                return ResourceManager.GetString("MyC_Code", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Imports Microsoft.VisualBasic, System, MMBot
        ///
        ///Public Class MMBotCodeClass
        ///    Private Shared isRunning As Boolean = False
        ///    Public Shared Function CustomCode(ByVal network As IRC, ByVal channel as IRCChannel) As Object
        ///        If isRunning Then Return Nothing
        ///        isRunning = True
        ///&apos;CODE GOES HERE
        ///        Return &quot;Done&quot;
        ///    End Function
        ///End Class.
        /// </summary>
        internal static string MyCode {
            get {
                return ResourceManager.GetString("MyCode", resourceCulture);
            }
        }
    }
}

﻿using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace MockLanguageExtension
{
    /// <summary>
    /// This package only loads when the FooLanguageClient.UiContextGuidString UI context is set.  This ensures that this extension is only loaded when the language server is activated.
    /// </summary>
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)] // Info on this package for Help/About
    [ProvideAutoLoad(JavaLanguageClient.UiContextGuidString)]
    [Guid(PackageGuidString)]
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "pkgdef, VS and vsixmanifest are valid VS terms")]
    public sealed class JavaPackage : Package
    {
        /// <summary>
        /// CustomCommandPackage GUID string.
        /// </summary>
        public const string PackageGuidString = "330ce502-4e1f-44b8-ab32-82a7ea71beeb";

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomCommand"/> class.
        /// </summary>
        public JavaPackage()
        {
        }

        #region Package Members

        /// <summary>
        /// Initialization of the package; this method is called right after the package is sited, so this is the place
        /// where you can put all the initialization code that rely on services provided by VisualStudio.
        /// </summary>
        protected override void Initialize()
        {
            base.Initialize();
        }

        #endregion
    }
}
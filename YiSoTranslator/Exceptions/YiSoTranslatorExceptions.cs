﻿using System;
using System.Diagnostics;

namespace YiSoTranslator
{
    /// <summary>
    /// the base Exception class for YiSoTranslator Exceptions
    /// </summary>
    [DebuggerStepThrough]
    public class YiSoTranslatorExceptions : Exception
    {
        /// <summary>
        /// default Constructor with Error message
        /// </summary>
        /// <param name="message">the Error message</param>
        public YiSoTranslatorExceptions(string message)
            : base(message)
        {

        }
    }

    #region Save and Read

    /// <summary>
    /// Exception Unsaved Changes Error
    /// </summary>
    [DebuggerStepThrough]
    public class UnsavedChangesExceptions : YiSoTranslatorExceptions
    {
        /// <summary>
        /// default Constructor with Error message
        /// </summary>
        public UnsavedChangesExceptions()
            : base("you have Unsaved Changes in your manager try to save them first, if you want to discard the changes pass 'true' to the Reload function")
        {

        }
    }

    #endregion

    #region File/Folder Exceptions

    /// <summary>
    /// Exception for Not finding the Translations Folder
    /// </summary>
    [DebuggerStepThrough]
    public class TranslationFolderMissingExceptions : YiSoTranslatorExceptions
    {
        /// <summary>
        /// default Constructor with Error message
        /// </summary>
        public TranslationFolderMissingExceptions()
            : base("The Translation Folder is not exist, Try to create a new folder and call it 'Translations'.")
        {

        }
    }

    /// <summary>
    /// Exception for not finding the Translation file
    /// </summary>
    [DebuggerStepThrough]
    public class TranslationFileMissingExceptions : YiSoTranslatorExceptions
    {
        /// <summary>
        /// constructor with the file name
        /// </summary>
        /// <param name="FileName"></param>
        public TranslationFileMissingExceptions(string FileName)
            : base($"The Translation file '{FileName}' doesn't exist.")
        {

        }

        /// <summary>
        /// default constructor
        /// </summary>
        public TranslationFileMissingExceptions()
            : base("The Translation file you specified doesn't exist.")
        {

        }
    }

    /// <summary>
    /// Exception For having a null Translation File object
    /// </summary>
    [DebuggerStepThrough]
    public class TranslationFileNotSpecifiedExceptions : YiSoTranslatorExceptions
    {
        /// <summary>
        /// default constructor
        /// </summary>
        public TranslationFileNotSpecifiedExceptions()
            : base("The Translation file is null, you didn't Specified a translation file.")
        {

        }
    }

    /// <summary>
    /// Exception For not having a JSON extension file
    /// </summary>
    [DebuggerStepThrough]
    public class NonValidTranslationFileExtensionExceptions : YiSoTranslatorExceptions
    {
        /// <summary>
        /// default constructor with the file extension
        /// </summary>
        public NonValidTranslationFileExtensionExceptions(string extension)
            : base($"The Translation file you specified must have a '.json' extension not '{extension}'.")
        {

        }
    }

    #endregion

    #region Translations Group Exceptions

    /// <summary>
    /// Exception For finding a similar Translations group with the same name in the translations list
    /// </summary>
    [DebuggerStepThrough]
    public class TranslationsGroupAlreadyExistException : YiSoTranslatorExceptions
    {
        /// <summary>
        /// default constructor with translationsGroup Name
        /// </summary>
        public TranslationsGroupAlreadyExistException(string translationGroupName)
            : base($"You already have a TranslationGroup with the given name '{translationGroupName}")
        {

        }
    }

    /// <summary>
    /// Exception For not finding a translations group with the given name in the list of translations
    /// </summary>
    [DebuggerStepThrough]
    public class TranslationsGroupNotExistException : YiSoTranslatorExceptions
    {
        /// <summary>
        /// default constructor with translationGroup Name
        /// </summary>
        public TranslationsGroupNotExistException(string translationGroupName)
            : base($"You don't have a TranslationGroup with the given name '{translationGroupName}'!")
        {

        }
    }

    #endregion

    #region Translations Exceptions

    /// <summary>
    /// Exception for not finding the translation
    /// </summary>
    [DebuggerStepThrough]
    public class TranslationNotExistExceptions : YiSoTranslatorExceptions
    {
        /// <summary>
        /// default constructor
        /// </summary>
        public TranslationNotExistExceptions()
            : base("You don't have a Translation with the given Language in your translation group")
        {

        }

        /// <summary>
        /// constructor with prams
        /// </summary>
        /// <param name="translationGroupName"></param>
        /// <param name="LanguageCode"></param>
        public TranslationNotExistExceptions(string translationGroupName, string LanguageCode)
            : base($"You don't have a Translation with the given Language '{LanguageCode} " +
                    $"in {translationGroupName} group")
        {

        }
    }

    /// <summary>
    /// Exception For finding a similar Translation in the given group name
    /// </summary>
    [DebuggerStepThrough]
    public class TranslationAlreadyExistExceptions : YiSoTranslatorExceptions
    {
        /// <summary>
        /// default constructor
        /// </summary>
        public TranslationAlreadyExistExceptions()
            : base("You already have a Translation with the given Language")
        {

        }

        /// <summary>
        /// constructor with prams
        /// </summary>
        /// <param name="translationGroupName"></param>
        /// <param name="LanguageCode"></param>
        public TranslationAlreadyExistExceptions(string translationGroupName, string LanguageCode)
            : base($"You already have a Translation with the given Language '{LanguageCode} in " +
                    $"{translationGroupName} group")
        {

        }
    }

    #endregion

    #region Language Exceptions

    /// <summary>
    /// Exception for Invalid Language Code
    /// </summary>
    [DebuggerStepThrough]
    public class InvalidLanguageCode : YiSoTranslatorExceptions
    {
        /// <summary>
        /// constructor with prams
        /// </summary>
        /// <param name="LanguageCode">the language code</param>
        public InvalidLanguageCode(string LanguageCode)
            : base($"there is no Language with the given Language code : '{LanguageCode}'")
        {

        }
    }

    /// <summary>
    /// Exception for Invalid Language Code
    /// </summary>
    [DebuggerStepThrough]
    public class InvalidLanguageName : YiSoTranslatorExceptions
    {
        /// <summary>
        /// constructor with prams
        /// </summary>
        /// <param name="LanguageName">the language name</param>
        public InvalidLanguageName(string LanguageName)
            : base($"there is no Language with the given Language Name : '{LanguageName}'")
        {

        }
    }

    #endregion
}

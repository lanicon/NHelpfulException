﻿namespace NHelpfulExceptions
{
    using System;

    /// <summary>
    ///   When used as a base for custom exceptions, 
    ///   forces the supply of a message upon instantiation.
    /// </summary>
    public abstract class HelpfulException : Exception
    {
        //NOTE: BA; these are not constants to prevent issues
        //across different versions of this functionality.
        private static readonly string ResolutionSuggestionListPrefix = "\r\nSuggestions:\r\n";
        private static readonly string ResolutionSuggestionPrefix = " - ";
        private static readonly string ResolutionSuggestionDelimiter = "\r\n";
        private static readonly string ResolutionSuggestionListSuffix = "\r\n";

        protected HelpfulException(string problemDescription,
                                   string[] resolutionSuggestions = default(string[]),
                                   Exception innerException = default(Exception))
            : base(problemDescription + resolutionSuggestions.ToPrettyPrintList(ResolutionSuggestionListPrefix,
                                                                                ResolutionSuggestionPrefix,
                                                                                ResolutionSuggestionDelimiter,
                                                                                ResolutionSuggestionListSuffix),
                   innerException) {}
    }
}
using System;
using System.Text.RegularExpressions;

namespace LogProcessing
{
    public class LogParser
    {
        private readonly string validLineRegexPattern;
        private readonly string splitLineRegexPattern;
        private readonly string quotedPasswordRegexPattern;
        private readonly string endOfLineRegexPattern;
        private readonly string weakPasswordRegexPattern;

        public LogParser()
        {
            validLineRegexPattern = @"^\[(TRC|DBG|INF|WRN|ERR|FTL)\]";
            splitLineRegexPattern = @"<\*{3}>|<====>|<\^\*>";
            quotedPasswordRegexPattern = "\".*?password.*?\"";
            endOfLineRegexPattern = @"end-of-line\d+";
            weakPasswordRegexPattern = @"password[a-zA-Z0-9]+";
        }

        public bool IsValidLine(string text)
        {
            if (string.IsNullOrEmpty(text))
                return false;

            return Regex.IsMatch(text, validLineRegexPattern);
        }

        public string[] SplitLogLine(string text)
        {
            if (string.IsNullOrEmpty(text))
                return Array.Empty<string>();

            return Regex.Split(text, splitLineRegexPattern);
        }

        public int CountQuotedPasswords(string lines)
        {
            if (string.IsNullOrEmpty(lines))
                return 0;

            return Regex.Matches(
                lines,
                quotedPasswordRegexPattern,
                RegexOptions.IgnoreCase
            ).Count;
        }

        public string RemoveEndOfLineText(string line)
        {
            if (string.IsNullOrEmpty(line))
                return line;

            return Regex.Replace(line, endOfLineRegexPattern, "").Trim();
        }

        public string[] ListLinesWithPasswords(string[] lines)
        {
            if (lines == null || lines.Length == 0)
                return Array.Empty<string>();

            string[] result = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                Match match = Regex.Match(
                    lines[i],
                    weakPasswordRegexPattern,
                    RegexOptions.IgnoreCase
                );

                if (match.Success)
                {
                    result[i] = $"{match.Value}: {lines[i]}";
                }
                else
                {
                    result[i] = $"--------: {lines[i]}";
                }
            }

            return result;
        }
    }
}

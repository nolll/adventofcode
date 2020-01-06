using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Core.Tools;

namespace Core.SleepingGuards
{
    public static class GuardEventReader
    {
        public static List<GuardEvent> Read(string str)
        {
            return StringListReader.Read(str).Select(ConvertToGuardEvent).OrderBy(o => o.Timestamp).ToList();
        }

        private static GuardEvent ConvertToGuardEvent(string str)
        {
            var regex = new Regex(@"^\[(.+)\] (.+)$");
            var match = regex.Match(str);
            var timestamp = GetTimeValue(match.Groups[1]);
            var action = match.Groups[2].Value;
            return new GuardEvent(timestamp, action);
        }

        private static DateTime GetTimeValue(Group matchGroup)
        {
            return DateTime.Parse(matchGroup.Value);
        }
    }
}
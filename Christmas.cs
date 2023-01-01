using System;
using System.Diagnostics;

namespace ChristmasWithTypes
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public partial class Christmas
    {
        public string[] Presents;
        public string Santa { get; set; }
        public int? TreeHeight { get; set; } //TODO Make the Height property nullable
            
    public enum Day { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday/*Fill out the days of the week*/ };

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}

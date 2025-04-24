using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework_1551
{
    internal class StringProcessing
    {
        private string _input;
        private int _shift;
        private string _output;

        public string Input
        {
            get => _input;
            set
            {
                if (!value.All(char.IsUpper) || value.Length > 40)
                    throw new ArgumentException("Input must be up to 40 capital letters.");
                _input = value;
            }
        }

        public int Shift
        {
            get => _shift;
            set
            {
                if (value < -25 || value > 25)
                    throw new ArgumentException("Shift must be between -25 and 25.");
                _shift = value;
            }
        }

        public StringProcessing(string input, int shift)
        {
            Input = input;
            Shift = shift;
        }

        public void Encode()
        {
            _output = new string(_input.Select(c =>
            {
                int offset = (_shift + 26) % 26;
                return (char)((((c - 'A') + offset) % 26) + 'A');
            }).ToArray());
        }

        public string Print() => _output;

        public int[] InputCode() => _input.Select(c => (int)c).ToArray();

        public int[] OutputCode() => _output.Select(c => (int)c).ToArray();

        public string Sort() => new string(_input.OrderBy(c => c).ToArray());
    }
}

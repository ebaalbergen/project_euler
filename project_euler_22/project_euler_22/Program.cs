using System;
using System.IO;
using System.Collections;
using System.Text;

namespace project_euler_22
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList names = new ArrayList();

            {
                FileStream nameFile = new FileStream("p022_names.txt", FileMode.Open);
                StringBuilder builder = new StringBuilder();

                while (true)
                {
                    sbyte letterByte = (sbyte)nameFile.ReadByte();
                    char letter = (char)letterByte;

                    if (letterByte == -1)
                        break;
                    else
                    {
                        if (letter == '"')
                        {
                            if (builder.Length != 0)
                            {
                                names.Add(builder.ToString());
                                builder = new StringBuilder();
                            }
                        }
                        else if (Char.IsLetter(letter))
                        {
                            builder.Append(letter);
                        }
                    }
                }
                nameFile.Close();
            }

            names.Sort();

            int totalValue = 0;
            int i = 1;
            foreach (string name in names)
            {
                Name naam = new Name(name, i);
                totalValue += naam.getNameValue();
                i++;
            }
            Console.Write(totalValue);
            Console.Read();

        }
    }

    class Name
    {
        private string name { get; set; }
        internal int alphabeticalValue { get; set; }
        internal int position { get; set; }

        public Name(string name, int position)
        {
            this.name = name;
            this.position = position;
            setAlphabeticalValue();
        }

        private void setAlphabeticalValue()
        {
            alphabeticalValue = 0;
            for(int x = 0; x < name.Length; x++)
            {
                char letter = name[x];
                if (Char.IsLetter(letter))
                {
                    letter = Char.ToLower(letter);
                }

                switch (letter)
                {
                    case 'a':
                        alphabeticalValue += 1;
                        break;
                    case 'b':
                        alphabeticalValue += 2;
                        break;
                    case 'c':
                        alphabeticalValue += 3;
                        break;
                    case 'd':
                        alphabeticalValue += 4;
                        break;
                    case 'e':
                        alphabeticalValue += 5;
                        break;
                    case 'f':
                        alphabeticalValue += 6;
                        break;
                    case 'g':
                        alphabeticalValue += 7;
                        break;
                    case 'h':
                        alphabeticalValue += 8;
                        break;
                    case 'i':
                        alphabeticalValue += 9;
                        break;
                    case 'j':
                        alphabeticalValue += 10;
                        break;
                    case 'k':
                        alphabeticalValue += 11;
                        break;
                    case 'l':
                        alphabeticalValue += 12;
                        break;
                    case 'm':
                        alphabeticalValue += 13;
                        break;
                    case 'n':
                        alphabeticalValue += 14;
                        break;
                    case 'o':
                        alphabeticalValue += 15;
                        break;
                    case 'p':
                        alphabeticalValue += 16;
                        break;
                    case 'q':
                        alphabeticalValue += 17;
                        break;
                    case 'r':
                        alphabeticalValue += 18;
                        break;
                    case 's':
                        alphabeticalValue += 19;
                        break;
                    case 't':
                        alphabeticalValue += 20;
                        break;
                    case 'u':
                        alphabeticalValue += 21;
                        break;
                    case 'v':
                        alphabeticalValue += 22;
                        break;
                    case 'w':
                        alphabeticalValue += 23;
                        break;
                    case 'x':
                        alphabeticalValue += 24;
                        break;
                    case 'y':
                        alphabeticalValue += 25;
                        break;
                    case 'z':
                        alphabeticalValue += 26;
                        break;
                }
            }
        }

        public int getNameValue()
        {
            return alphabeticalValue * position;
        }
    }
}

namespace Latypova;


    struct Ded
    {
        public string Name;
        public GrumpinessLevel Grumpiness;
        public string[] Phrases;
        public int BlackEyes;

        public Ded(
            string name,
            GrumpinessLevel grumpiness,
            string[] phrases)
        {
            Name = name;
            Grumpiness = grumpiness;
            Phrases = phrases;
            BlackEyes = 0;
        }

        public int CheckBadWords(params string[] badWords)
        {
            int count = 0;

            foreach (string phrase in Phrases)
            {
                foreach (string word in badWords)
                {
                    if (phrase.Contains(
                            word,
                            StringComparison.OrdinalIgnoreCase))
                    {
                        BlackEyes++;
                        count++;
                    }
                }
            }

            return count;
        }
    }

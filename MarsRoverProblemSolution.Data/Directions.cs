namespace MarsRoverProblemSolution.Data
{
    public sealed class Directions : EnumBase
    {
        public static Directions N { get; }
        public static Directions S { get; }

        public static Directions E { get; }
        public static Directions W { get; }

        public static Directions RIP { get;}


        static Directions()
        {
            N = new Directions(nameof(N), 1);
            S = new Directions(nameof(S), 2);
            E = new Directions(nameof(E), 3);
            W = new Directions(nameof(W), 4);
            RIP = new Directions(nameof(RIP), 5);

        }

        private Directions(string key, int value) : base(key, value)
        {
        }
    }
}

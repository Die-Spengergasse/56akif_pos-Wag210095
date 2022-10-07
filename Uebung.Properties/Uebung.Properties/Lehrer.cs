namespace ExProperties.App
{
    internal class Lehrer
    {
        private decimal? _bG;
        private decimal? _nG;

        public string? Vorname { get;  set; } = string.Empty;
        public string? Zuname { get;  set; }
        public decimal? Bruttogehalt
        {
            get { return _bG; }
            set
            {
                if (_bG != null)
                {
                    _bG = value;
                }
            }
        }
        public decimal? Nettogehalt
        {
            get { return _nG * 0.8M; } 

            set
            {
                if (_bG == null)
                {

                    _nG = 0;

                }
            } 
        }
        public string? Kuerzel { get;  set; } //keine Ahnung
    }
}
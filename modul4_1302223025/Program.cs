using System;
using System.Diagnostics;
using static Program.KodeBuah;
using static Program.PosisiKarakterGame;
public class Program
{
    public class KodeBuah
    {
        public enum namaBuah
        {
            Apel,
            Aprikot,
            Alpukat,
            Pisang,
            Paprika,
            Blackberry,
            Ceri,
            Kelapa,
            Jagung,
            Kurma,
            Durian,
            Anggur,
            Melon,
            Semangka
        }

        public static string getKodeBuah(namaBuah nama)
        {
            string[] kodeBuah = { "A00","B00","C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00"};
            return kodeBuah[(int)nama]; 
        }
    }

    public class PosisiKarakterGame
    {
        public enum PosisiState { BERDIRI, JONGKOK, TERBANG, TENGKURAP};
        public enum Trigger { TombolW, TombolS, TombolX};

        public class Transition
        {
            public PosisiState StateAwal;
            public PosisiState StateAkhir;
            public Trigger Trigger;
            public Transition(PosisiState stateAwal, PosisiState stateAkhir, Trigger trigger) 
            { 
                StateAwal = stateAwal;
                StateAkhir = stateAkhir;
                Trigger = trigger;
            }
        }
        Transition[] transisi =
        {
            new Transition(PosisiState.BERDIRI, PosisiState.TERBANG, Trigger.TombolW),
            new Transition(PosisiState.BERDIRI, PosisiState.JONGKOK, Trigger.TombolS),
            new Transition(PosisiState.TERBANG, PosisiState.BERDIRI, Trigger.TombolS),
            new Transition(PosisiState.TERBANG, PosisiState.JONGKOK, Trigger.TombolX),
            new Transition(PosisiState.JONGKOK, PosisiState.BERDIRI, Trigger.TombolW),
            new Transition(PosisiState.JONGKOK, PosisiState.TENGKURAP, Trigger.TombolS),
            new Transition(PosisiState.TENGKURAP, PosisiState.JONGKOK, Trigger.TombolW)
        };
        public PosisiState currentState = PosisiState.BERDIRI;
        public PosisiState GetNextState(PosisiState stateAwal, Trigger trigger) 
        { 
            PosisiState stateAkhir = stateAwal;
            for (int i=0; i<transisi.Length; i++)
            {
                Transition perubahan = transisi[i];
                if (stateAwal == perubahan.StateAwal && trigger == perubahan.Trigger)
                {
                    stateAkhir = perubahan.StateAkhir;
                }
            }
            return stateAkhir;
        }

        public void ActiveTrigger(PosisiState stateAwal , Trigger trigger) 
        {
            currentState = GetNextState(stateAwal, trigger);
            if (stateAwal == PosisiState.TERBANG && trigger == Trigger.TombolX)
            {
                Console.WriteLine("Posisi Landing");
            } else if (stateAwal == PosisiState.BERDIRI && trigger == Trigger.TombolW)
            {
                Console.WriteLine("Posisi Take off");
            }
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Buah " + namaBuah.Kurma + " Memiliki kode buah " + getKodeBuah(namaBuah.Kurma));

        PosisiKarakterGame posisi = new PosisiKarakterGame();

        Console.Write("State dari TERBANG ke JONGKOK ");
        posisi.ActiveTrigger(PosisiState.TERBANG, Trigger.TombolX);
        Console.Write("State dari BERDIRI ke TERBANG ");
        posisi.ActiveTrigger(PosisiState.BERDIRI, Trigger.TombolW);
    }
}
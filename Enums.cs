using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoinPokerCommonLib
{
    public class Enums
    {
        public enum TournamentPrizeType
        {
            STATIC
        }

        public enum GameListType
        {
            Normal,
            SitAndGo
        }

        public enum TournamentState
        {
            Announced = 0,
            Registration = 1,
            LateRegistration = 2,
            Running = 3,
            Completed = 4
        }

        public enum HandType
        {
            StraightFlush,
            Flush,
            Straight,
            FullHouse,
            FourOfAKind,
            ThreeOfAKind,
            TwoPair,
            Pair,
            HighCard
        }

        public enum TournamentOption
        {
            SitAndGo,       //Rozpoczyna się po otrzymaniu konkretnej ilośći graczy
            //Bounty_Knockout,//Otrzymuje część kwoty za wyeleminowanie gracza
            //Bounty_ProgressiveKnockout, //Nagrody rosną wraz z ilością wyeleminowanych graczy
            Fifty50,        //Kończy się gdy odpadnie połowa uczestników
            //Rebuy,          //Pozwala na rebuye przez okreslony czas (ilosć poziomów)
            Max6,           //Max. 6 graczy przy stole
            Turbo,          //Szybsze poziomy, częstsze przerwy
            Time,           //Określony czas, po nim zakończenie turnieju 
        }

        public enum CurrencyType
        {
            VIRTUAL = 0,
            BTC = 1,
            USD = 2,
        }

        public enum TransferType
        {
            WITHDRAW,
            DEPOSIT
        }

        public enum ActionPokerType
        {
            BigBlind,
            SmallBlind,
            Fold,
            Call,
            Raise
        }

        public enum Stage
        {
            Preflop,
            Flop,
            Turn,
            River
        }

        public enum GameActionType
        {
            Watch, //Obserwacja
            Unwatch, //Zaprzestanie obserwacji
            Booking, //Rezerwacja miejsca
            PlayerActivation, //Wrócenie do gry ze statusu leave etc.
            LeaveGame, //Wyjście z gry przez okienko
            FindAnotherTable, //Znajduje nowy stół do gry
        }

        public enum PokerGameType
        {
            Holdem = 0,
            Omaha = 1,
        }

        public enum TableAction
        {
            Watch,
            Unwatch,
            Join,
            Leave
        }

        public enum LimitType
        {
            Fixed = 0,
            PotLimit = 1,
            NoLimit = 2,
        }

        public enum TableType
        {
            Normal,     //Stół do gry normalny
            Tournament, //Stół dla turniejów
        }

    }
}

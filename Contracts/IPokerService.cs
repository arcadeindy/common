using CoinPokerCommonLib.GameModes;
using CoinPokerCommonLib.Models.Game.TournamentOption;
using Hik.Communication.ScsServices.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoinPokerCommonLib.Models;

namespace CoinPokerCommonLib
{
    [ScsService(Version = "1.0.0.0")]
    public interface IPokerService
    {
        /// <summary>
        /// Logowanie za pomocą session_id
        /// </summary>
        /// <param name="session_id"></param>
        /// <param name="hash"></param>
        void DoLogin(string username, string password);

        /// <summary>
        /// Rejestracja użytkownika
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        bool DoRegister(UserModel user);

        /// <summary>
        /// Zmiana hasła
        /// </summary>
        /// <param name="oldPassword"></param>
        /// <param name="newPassword"></param>
        /// <returns></returns>
        bool DoChangePassword(string oldPassword, string newPassword);

        /// <summary>
        /// Wylogowanie
        /// </summary>
        void DoLogout();

        /// <summary>
        /// Pobiera listę stołów do gry
        /// </summary>
        List<NormalGameModel> GetNormalModeList();

        /// <summary>
        /// Pobiera listę stołów do gry
        /// </summary>
        List<ITournamentGameModel> GetTournamentModeList();

        /// <summary>
        /// Pobiera informacje oo graczach przy stole
        /// </summary>
        List<PlayerModel> GetTablePlayers(TableModel table);

        /// <summary>
        /// Pobiera liste graczy turniejowych
        /// </summary>
        /// <param name="tournament"></param>
        /// <returns></returns>
        List<TournamentPlayerModel> GetTournamentPlayers(ITournamentGameModel tournament);

        /// <summary>
        /// Lista turniejow w ktorych jest zarejestrowany gracz
        /// </summary>
        /// <param name="tournament"></param>
        /// <returns></returns>
        List<ITournamentGameModel> RegisteredTournamentList();

        /// <summary>
        /// Pobiera profil użytkownika
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        ProfileModel GetProfileUser(UserModel user);

        /// <summary>
        /// Pobiera nową reklamę do lobby
        /// </summary>
        void GetAdsLobby();

        /// <summary>
        /// Wysyła określony typ akcji od użytkownika dla danego stołu do gry
        /// </summary>
        /// <param name="actionType"></param>
        /// <param name="table"></param>
        void DoAction(Enums.GameActionType actionType, TableModel table);

        /// <summary>
        /// Akcja stołu Fold, Call, Raise
        /// </summary>
        void DoGameAction(TableModel table, Enums.ActionPokerType action, decimal actionValue);

        /// <summary>
        /// Dołącza do trybu normalnego
        /// </summary>
        /// <param name="table"></param>
        /// <param name="stack"></param>
        void DoJoinNormalMode(NormalGameModel game, int placeID, decimal stack);

        /// <summary>
        /// Dołącza do gry turniejowej
        /// </summary>
        /// <param name="tournament"></param>
        void DoJoinTournamentMode(ITournamentGameModel tournament);

        /// <summary>
        /// Wyjście z turnieju
        /// </summary>
        void DoLeftTournamentMode(ITournamentGameModel tournament);

        /// <summary>
        /// Pobiera stol gracza, jesli jest zarejsetrowany w turnieju i nie wyapdl z niego
        /// </summary>
        /// <param name="tournament"></param>
        /// <returns></returns>
        TableModel GetTournametTable(ITournamentGameModel tournament);

        /// <summary>
        /// Wysyła wiadomość czatu
        /// </summary>
        void SendMessageToTable(TableModel table, string message);
        
        /// <summary>
        /// Pobiera model gry na podstawie stołu
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        IGameModel GetGameModelByTable(TableModel table);

        /// <summary>
        /// Zmienia avatar użytkownika
        /// </summary>
        /// <param name="newAvatar"></param>
        /// <returns></returns>
        string DoChangeUserAvatar(byte[] newAvatar);

        /// <summary>
        /// Pobiera listę portfeli
        /// </summary>
        /// <returns></returns>
        List<WalletModel> GetWalletList();

        /// <summary>
        /// Pobiera konkretny portfel
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        WalletModel GetWallet(Enums.CurrencyType type);

        /// <summary>
        /// Pobiera listę operacji na portfelu
        /// </summary>
        /// <param name="wallet"></param>
        /// <returns></returns>
        List<TransferModel> GetTransferOperations(WalletModel wallet);

        /// <summary>
        /// Wysyła żądanie transferu środków danego typu portfela
        /// </summary>
        /// <param name="type"></param>
        void DoTransferRequest(Enums.CurrencyType type);
    }
}

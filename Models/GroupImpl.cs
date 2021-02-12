using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace Bet.Models
{
    public class GroupImpl:Group
    {

        public int Id { get; set; }
        public int BetId { get; set; }
        [Required]
        [StringLength(250)]
        [Display(Name = "Group Name")]
        public string GroupName { get; set; }
        [Required]
        public Player Player { get; set; }
        public LinkedList<Player> Players { get; set; }
        [Required]
        public int JoinCode { get; set; }

        public BetImpl Bet { get; set; }

        public LinkedList<BetImpl> Bets { get; set; }

        public bool GameIsConfirmed { get; set; }
        public bool BetsAreConfirmed { get; set; }

        //*****======= private fields ******==========
        private string _groupName;
        private Player _player;
        private LinkedList<Player> playerList;
        private int _joinCode;
        private Bet bet;
        private bool _confirmGame =false;
        private bool _isBetOutComeConfirmed = false;
        public enum _groupStatus { Confirmed, Cancel, }

        public GroupImpl( string groupName, Player player, LinkedList<Player> playerList, int joinCode,
            Bet bet, bool confirmGame, bool isBetOutComeConfirmed)
        {
            _groupName = groupName ?? throw new ArgumentNullException(nameof(groupName));
            _player = player ?? throw new ArgumentNullException(nameof(player));
            this.playerList = playerList ?? throw new ArgumentNullException(nameof(playerList));
            _joinCode = joinCode;
            this.bet = bet ?? throw new ArgumentNullException(nameof(bet));
            _confirmGame = confirmGame;
            _isBetOutComeConfirmed = isBetOutComeConfirmed;
        }

        //*****====== Public Methods =======**********

        public string GetGroupName()
        {
           return _groupName;
        }

        public void SetGroupName(string groupName)
        {
            this._groupName = groupName;
        }

        public Player GetPlayer()
        {
            return _player;
        }

        public void SetPlayer(Player player)
        {
            _player = player;
            playerList.AddLast(player);
        }

        public LinkedList<Player> GetPlayers()
        {
            return playerList;
        }

        public void JoinGroupWithJoinCode(int joinCode, Player player)
        {
            if (_joinCode == joinCode && player != null)
            {
                playerList.AddLast(player);
            }
        }

        public void SetJoinCode()
        {
            _joinCode = GetHashCode();
        }

        public int GetJoinCode(Group group)
        {
            return _joinCode;
        }

        public void ConfirmGame(Player player)
        {
            if(_player != null && _player == player)
            {
                _confirmGame = true;
            }
         
        }

        public void ConfirmGameOutcome(Player player)
        {
            foreach (var checkPlayer in playerList)
            {
                if (player == checkPlayer)
                {
                    if (player != null)
                    {
                        _isBetOutComeConfirmed = true;
                    }
                }
            }
            
        }
        public bool IsGameConfirmed()
        {
            return _confirmGame;
        }

        public bool GetIsBetOutComeConfirmed()
        {
            return _isBetOutComeConfirmed;
        }
    }
}
﻿using NFLPlayerReview.Data;
using NFLPlayerReview.Interfaces;
using NFLPlayerReview.Models;

namespace NFLPlayerReview.Repository
{
    public class NFLPositionRepository : INFLPositionRepository
    {
        private readonly DataContext _context;

        public NFLPositionRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<NFLPosition> GetNFLPositions()
        {
            return _context.NFLPositions.ToList();
        }
        
        public NFLPosition GetNFLPositionByID(int id)
        {
            return _context.NFLPositions.Where(p => p.Id == id).FirstOrDefault();
        }

        public ICollection<NFLPlayer> GetNFLPlayerByPosition(int positionId)
        {
            return _context.PlayerPosititions.Where(p => p.PositionId == positionId).Select(x => x.Player).ToList();
        }


        public bool NFLPositionExists(int id)
        {
            return _context.NFLPlayers.Any(p => p.Id == id);
        }
    }
}
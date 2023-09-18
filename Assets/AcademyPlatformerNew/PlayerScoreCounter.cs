using System;
using Sounds;

namespace AcademyPlatformerNew
{
    public class PlayerScoreCounter
    {
        public event Action<int> ScoreChangeNotify;
        public int Score => _score;

        private SoundController _soundController;

        private int _score = 0;

        public PlayerScoreCounter(
            SoundController soundController)
        {
            _soundController = soundController;
        }

        public void SetScores(int amount = 0)
        {
            _score = amount;
            ScoreChangeNotify?.Invoke(_score);
        }
    
        public void AddScores(int amount)
        {
            _soundController.Play(SoundName.Buff1);
            _score += amount;
            ScoreChangeNotify?.Invoke(_score);
        }        

        public void ReduceScores(int amount)
        {
            _soundController.Play(SoundName.GetDamage);
            _score -= amount;
            ScoreChangeNotify?.Invoke(_score);
        }
    }
}
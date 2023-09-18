namespace UI.HUD
{
    public class HUDWindowController
    {
        private readonly UIService.UIService _uiService;
        
        private HUDWindow _hudWindow;

        public HUDWindowController(UIService.UIService uiService)
        {
            _uiService = uiService;
            _hudWindow = uiService.Get<HUDWindow>();
            
            SetParameters();
        }
        
        public void ChangeHealthPoint(float healthPoint)
        {
            healthPoint = ChekHPPoint(healthPoint, _hudWindow.СurrentHealth);
            _hudWindow.ChangeHealthBar(healthPoint);
        }
        
        public void ChangePlayerScore(int score)
        {
            _hudWindow.ChangeScoreText(score);
        }
        
        public void SetParameters(int score = 0, float healthPoint = 100f)
        {
            ChangePlayerScore(score);
            
            healthPoint = ChekHPPoint(healthPoint);
            _hudWindow.ChangeHealthBar(healthPoint);
        }

        private float ChekHPPoint(float healthPoint, float currentHP = 0)
        {
            healthPoint /= 100;
            currentHP /= 100;
            
            if (healthPoint + currentHP > 1)
            {
                currentHP = 1;
            }
            else if (healthPoint + currentHP < 0)
            {
                currentHP = 0;
            }
            else
            {
                currentHP += healthPoint;
            }
            return currentHP;
        }
    }
}
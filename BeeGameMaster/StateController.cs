using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BeeGameMaster
{
    class StateController
    {
        //private Game1 game1;
        //private GameState gameState;
        //
        ////mouse and keyboard states
        //private MouseState mState;
        //private MouseState prevMState;
        //private KeyboardState kbState;
        //private KeyboardState prevKbState;
        //
        ////main menu textures
        //private Texture2D Menu;
        //private Texture2D buttonStart;
        ////game over menu textures
        //private Texture2D GameOver;
        //private Texture2D buttonGameOverMainMenu;
        //private Texture2D buttonPlayAgain;
        ////win menu textures
        //private Texture2D Win;
        //
        ////main menu rectangle locations
        //private Rectangle MenuLoc;
        //private Rectangle buttonStartLoc;
        ////game over menu rectangle location
        //private Rectangle GameOverLoc;
        //private Rectangle buttonGameOverMenuMainLoc;
        //private Rectangle buttonPlayAgainLoc;
        ////win menu rectangle location
        //private Rectangle WinLoc;
        //
        ////menu console dimensions
        //private int menuWidth;
        //private int menuHeight;
        //
        //
        //
        //
        //
        ////main menu button colors TEMPORARY
        //private Color buttonStartColor;
        //
        ////game over button color TEMPORARY
        //private Color buttonMenuColor;
        //private Color buttonPlayAgainColor;
        //
        ////This enum keeps track of the possible game states.
        //public enum GameState
        //{
        //    Menu,
        //    Game,
        //    GameOver,
        //    Win
        //}
        //
        //
        ///// <summary>
        ///// This method loads in content needed for various gamestates.
        ///// </summary>
        ///// 
        ////This is a Test - Nicolas Jensen
        //public void LoadContent(Texture2D Menu,
        //                        Texture2D buttonStart,
        //                        Texture2D GameOver,
        //                        Texture2D buttonGameOverMainMenu,
        //                        Texture2D Win,
        //                        Texture2D buttonPlayAgain)
        //{
        //    //main menu
        //    this.Menu = Menu;
        //    this.buttonStart = buttonStart;
        //
        //    //game over
        //    this.GameOver = GameOver;
        //    this.buttonGameOverMainMenu = buttonGameOverMainMenu;
        //    this.buttonPlayAgain = buttonPlayAgain;
        //
        //    //win
        //    this.Win = Win;
        //}
        //public void Initialize()
        //{
        //    //menu
        //    menuWidth = game1.GraphicsDevice.Viewport.Width;
        //    menuHeight = game1.GraphicsDevice.Viewport.Height;
        //    MenuLoc = new Rectangle(menuWidth / 2 - menuWidth / 2, menuHeight / 2 - menuHeight / 2, menuWidth, menuHeight);
        //    buttonStartLoc = new Rectangle(menuWidth / 2 - menuWidth / 3, menuHeight / 12, (menuWidth * 2 / 3) + 37, menuHeight / 6);
        //
        //    //game over
        //    GameOverLoc = new Rectangle(menuWidth / 2 - menuWidth / 2, menuHeight / 2 - menuHeight / 2, menuWidth, menuHeight);
        //    buttonGameOverMenuMainLoc = new Rectangle(menuWidth / 2 - menuWidth / 3, (MenuLoc.Y + menuHeight / 3) + 10, (menuWidth * 2 / 3) + 37, menuHeight / 10);
        //    buttonPlayAgainLoc = new Rectangle(menuWidth / 2 - menuWidth / 3, (MenuLoc.Y + menuHeight / 3) + 10, (menuWidth * 2 / 3) + 37, menuHeight / 10);
        //
        //    //win 
        //    WinLoc = new Rectangle(menuWidth / 2 - menuWidth / 2, menuHeight / 2 - menuHeight / 2, menuWidth, menuHeight);
        //    buttonMenuColor = Color.White;
        //    buttonMenuColor = Color.White;
        //    buttonStartColor = Color.White;
        //}
        ///// <summary>
        ///// This state Controller method will help keep track/update the current game state the program will be in.
        ///// </summary>
        //public StateController(Game1 game1)
        //{
        //    this.gameState = new GameState();
        //    this.game1 = game1;
        //    this.gameState = GameState.Menu;
        //
        //    //this is here temp
        //    this.Menu = game1.Menu;
        //    this.buttonStart = game1.buttonStart;
        //    this.GameOver = game1.GameOver;
        //    this.buttonGameOverMainMenu = game1.buttonGameOverMainMenu;
        //    this.buttonPlayAgain = game1.buttonPlayAgain;
        //    this.Win = game1.Win;
        //
        //}
        //public void updateGameStates(GameTime gameTime)
        //{
        //    //updates states for player input checks
        //    prevMState = mState;
        //    prevKbState = kbState;
        //    mState = Mouse.GetState();
        //    kbState = Keyboard.GetState();
        //
        //    switch (gameState)
        //    {
        //        case GameState.Menu:
        //            if (buttonStartLoc.Contains(mState.Position))
        //            {
        //                if (prevMState.LeftButton == ButtonState.Pressed)
        //                {
        //                    buttonStartColor = Color.DarkCyan;
        //
        //                    if (mState.LeftButton == ButtonState.Released)
        //                    {
        //                        gameState = GameState.Game;
        //                    }
        //                }
        //                else
        //                {
        //                    buttonStartColor = Color.Cyan;
        //                }
        //            }
        //            break;
        //        case GameState.Game:
        //            gameState = GameState.GameOver;
        //            break;
        //        case GameState.GameOver:
        //            //if the menu button is pressed, the gamestate will update to menu
        //            if (buttonGameOverMenuMainLoc.Contains(mState.Position))
        //            {
        //                if (prevMState.LeftButton == ButtonState.Pressed)
        //                {
        //                    buttonMenuColor = Color.DarkGray;
        //
        //                    if (mState.LeftButton == ButtonState.Released)
        //                    {
        //                        gameState = GameState.Menu;
        //                    }
        //                }
        //                else
        //                {
        //                    buttonMenuColor = Color.White;
        //                }
        //            }
        //            //If the play again button is pressed, the gamestate will update to game
        //            else if (buttonPlayAgainLoc.Contains(mState.Position))
        //            {
        //                if (prevMState.LeftButton == ButtonState.Pressed)
        //                {
        //                    buttonPlayAgainColor = Color.DarkGray;
        //
        //                    if (mState.LeftButton == ButtonState.Released)
        //                    {
        //                        gameState = GameState.Game;
        //                        //Things will probably need to be reset here
        //                    }
        //                }
        //                else
        //                {
        //                    buttonPlayAgainColor = Color.White;
        //                }
        //            }
        //            else
        //            {
        //                buttonMenuColor = Color.White;
        //                buttonPlayAgainColor = Color.White;
        //            }
        //            break;
        //        case GameState.Win:
        //            //if the menu button is pressed, the gamestate will update to menu
        //            if (buttonGameOverMenuMainLoc.Contains(mState.Position))
        //            {
        //                if (prevMState.LeftButton == ButtonState.Pressed)
        //                {
        //                    buttonMenuColor = Color.DarkGray;
        //
        //                    if (mState.LeftButton == ButtonState.Released)
        //                    {
        //                        gameState = GameState.Menu;
        //                    }
        //                }
        //                else
        //                {
        //                    buttonMenuColor = Color.White;
        //                }
        //            }
        //            //If the play again button is pressed, the gamestate will update to game
        //            else if (buttonPlayAgainLoc.Contains(mState.Position))
        //            {
        //                if (prevMState.LeftButton == ButtonState.Pressed)
        //                {
        //                    buttonPlayAgainColor = Color.DarkGray;
        //
        //                    if (mState.LeftButton == ButtonState.Released)
        //                    {
        //                        gameState = GameState.Game;
        //                        //Things will probably need to be reset here
        //                    }
        //                }
        //                else
        //                {
        //                    buttonPlayAgainColor = Color.White;
        //                }
        //            }
        //            else
        //            {
        //                buttonMenuColor = Color.White;
        //                buttonPlayAgainColor = Color.White;
        //            }
        //            break;
        //    }
        //}
        //public void drawGameStates(SpriteBatch spriteBatch)
        //{
        //    switch (gameState)
        //    {
        //        case GameState.Menu:
        //            // TODO: GET MENU GRAPHICS
        //            game1.IsMouseVisible = true;
        //            spriteBatch.Draw(Menu, MenuLoc, Color.White);
        //            spriteBatch.Draw(buttonStart, buttonStartLoc, buttonStartColor);
        //            break;
        //        case GameState.GameOver:
        //            game1.IsMouseVisible = true;
        //            // TODO: GET GAME OVER SCREEN GRAPHICS
        //
        //            spriteBatch.Draw(GameOver, GameOverLoc, Color.White);
        //            spriteBatch.Draw(buttonGameOverMainMenu, buttonGameOverMenuMainLoc, buttonMenuColor);
        //            spriteBatch.Draw(buttonPlayAgain, buttonPlayAgainLoc, buttonPlayAgainColor);
        //            break;
        //        case GameState.Win:
        //            game1.IsMouseVisible = true;
        //            // TODO: GET GAME WIN SCREEN GRAPHICS
        //
        //            spriteBatch.Draw(Win, WinLoc, Color.White);
        //            spriteBatch.Draw(buttonGameOverMainMenu, buttonGameOverMenuMainLoc, Color.Red);
        //            break;
        //    }
        //}
    }
}

using System;
using System.Collections.Generic;

namespace RockPaperScissor.Models
{
  public class RockPaperScissorGame
  {
    private string pick;
    public RockPaperScissorGame(string playerPick)
    {
      pick = playerPick;
    }
    public string GetPick()
    {
      return pick;
    }

    public string GamePlay()
    {
      Random rnd = new Random();
      int rand = rnd.Next(1,4);
      string otherPick = "";
      if(rand == 1)
      {
        otherPick = "ROCK";
      }
      else if(rand == 2)
      {
        otherPick = "PAPER";
      }
      else
      {
        otherPick = "SCISSOR";
      }

      if (pick == "ROCK")
      {
        if (otherPick == "ROCK")
        {
          return "ROCK vs ROCK: Draw";
        } else if (otherPick == "PAPER")
        {
          return "ROCK vs PAPER: PAPER wins";
        } else
        {
          return "ROCK vs SCISSOR: ROCK wins";
        }
      } else if (pick == "PAPER")
      {
        if (otherPick == "ROCK")
        {
          return "PAPER vs ROCK: PAPER wins";
        } else if (otherPick == "PAPER")
        {
          return "PAPER vs PAPER: Draw";
        } else
        {
          return "PAPER vs SCISSOR: SCISSOR wins";
        }
      }  else if(pick == "SCISSOR")
      {
        if (otherPick == "ROCK")
        {
          return "SCISSOR vs ROCK: ROCK wins";
        } else if (otherPick == "PAPER")
        {
          return "SCISSOR vs PAPER: SCISSOR wins";
        } else
        {
          return "SCISSOR vs SCISSOR: Draw";
        }
      }
      else
      {
        return "Please type ROCK, PAPER, or SCISSOR.";
      }
    }
  }
}

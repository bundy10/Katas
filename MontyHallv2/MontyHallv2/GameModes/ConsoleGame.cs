
using MontyHallv2.DoorCreation;
using MontyHallv2.GameShowStaff;
using MontyHallv2.Interfaces;
using MontyHallv2.Messages;
using MontyHallv2.Strategies;
using MontyHallv2.Validation;

namespace MontyHallv2.GameModes;

public class ConsoleGame : IGameMode
{
    private int _choice;
    public void PlayerChooseDoor(List<Door> doors)
    {
        var userDoorSelection = GetDoorSelectionFromUser();
        while (!PlayerChoiceValidator.ValidateUserDoorSelection(userDoorSelection))
        {
            Dialog.InvalidDoorSelectionInputMessage();
            userDoorSelection = GetDoorSelectionFromUser();
        }
        _choice = int.Parse(userDoorSelection) - 1;
        doors[_choice].PlayerPickedDoor();
    }

    public void PlayerSwitchOrStayDoor(List<Door> doors)
    {
        
        var strategy = new ToSwitch();
        var userSwitchOrStayChoice = GetSwitchOrStayChoiceFromUser();

        while (!PlayerChoiceValidator.ValidateUserSwitchOrStayChoice(userSwitchOrStayChoice))
        {
            Dialog.InvalidSwitchOrStayChoiceInputMessage();
            userSwitchOrStayChoice = GetSwitchOrStayChoiceFromUser();
        }
        
        if (userSwitchOrStayChoice == "y")
        {
            strategy.ToSwitchOrStay(doors);
        }
    }

    public bool GetGameOutCome(List<Door> doors)
    {
        return Dialog.HostGameOutcome(doors);
    }
    
    public string? GetDoorSelectionFromUser()
    {
        Dialog.PromptPlayerToPickADoorMessage();
        return Console.ReadLine();
    }
    
    public string? GetSwitchOrStayChoiceFromUser()
    {
        Dialog.PromptPlayerToStayOrSwitchDoor();
        return Console.ReadLine();
    }
}
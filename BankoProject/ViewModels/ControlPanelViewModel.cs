﻿using BankoProject.Tools;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankoProject.Models;
using BankoProject.Tools.Events;

namespace BankoProject.ViewModels
{
  class ControlPanelViewModel : Conductor<IMainViewItem>.Collection.OneActive, IMainViewItem
  {
    private IEventAggregator _events;
    private BingoEvent _bingoEvent;
    private readonly ILog _log = LogManager.GetLog(typeof(MainWindowViewModel));
    private BoardViewModel _boardViewModel;
    private string _plateNumberTextBox;
    private string _contestName;
    private int _numberOfContestants;
    private int _numberOfTeams;
    private int _contestDuration;


    public ControlPanelViewModel()
    {
      BoardViewModel = new BoardViewModel();
      ActivateItem(BoardViewModel);
    }

    protected override void OnViewReady(object view)
    {
      _events = IoC.Get<IEventAggregator>();
      Event = IoC.Get<BingoEvent>();
      Event.BnkOptions.SingleRow = true;
      Event.VsOptions.EmptyScreen = true;

    }


    public void ShowWelcome()
    {
      _events.PublishOnUIThread(new CommunicationObject(ApplicationWideEnums.MessageTypes.ChngWelcomeView, ApplicationWideEnums.SenderTypes.ControlPanelView));
    }

    public BingoEvent Event
    {
      get { return _bingoEvent; }
      set { _bingoEvent = value; NotifyOfPropertyChange(() => Event); }
    }

    public BoardViewModel BoardViewModel
    {
      get { return _boardViewModel; }
      set { _boardViewModel = value; NotifyOfPropertyChange(()=> BoardViewModel);}
    }

    public string PlateNumberTextBox
    {
      get { return _plateNumberTextBox; }
      set { _plateNumberTextBox = value; NotifyOfPropertyChange(() => PlateNumberTextBox);}
    }

    public string ContestName
    {
      get { return _contestName; }
      set { _contestName = value; NotifyOfPropertyChange(() => ContestName);}
    }

    public int NumberOfContestants
    {
      get { return _numberOfContestants; }
      set { _numberOfContestants = value; NotifyOfPropertyChange(() => NumberOfContestants);}
    }

    public int NumberOfTeams
    {
      get { return _numberOfTeams; }
      set { _numberOfTeams = value; NotifyOfPropertyChange(() => NumberOfTeams);}
    }

    public int ContestDuration
    {
      get { return _contestDuration; }
      set { _contestDuration = value; NotifyOfPropertyChange(() => ContestDuration);}
    }

    public void ShowLatestNumbers()
    {
      throw new NotImplementedException();
    }

    public void BingoButton()
    {
      throw new NotImplementedException();
    }

    public void DrawRandom()
    {
      throw new NotImplementedException();
    }

    public void AddSelectedNumbers()
    {
      throw new NotImplementedException();
    }

    public void CheckPlateButton()
    {
      throw new NotImplementedException();
    }

    public void AddTeamButton()
    {
      throw new NotImplementedException();
    }

    public void StartContest()
    {
      throw new NotImplementedException();
    }





  }
}

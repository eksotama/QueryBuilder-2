﻿using Nodes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualQueryApplication.Model;

namespace VisualQueryApplication.ViewModels
{
    public class GraphEditorViewModel : ViewModelBase
    {
        public ObservableCollection<VisualNodeViewModel> VisualNodes
        {
            get
            {
                return visualNodes;
            }
            set
            {
                visualNodes = value;
                OnPropertyChanged(nameof(VisualNodes));
            }
        }

        private ObservableCollection<VisualNodeViewModel> visualNodes = new ObservableCollection<VisualNodeViewModel>();

        public ObservableCollection<ConnectionViewModel> Connections
        {
            get
            {
                return connections;
            }
            set
            {
                connections = value;
                OnPropertyChanged(nameof(Connections));
            }
        }

        private ObservableCollection<ConnectionViewModel> connections = new ObservableCollection<ConnectionViewModel>();

        public GraphEditorViewModel()
        {
        }

        public int FindMaxZIndex()
        {
            int count = 0;

            if (visualNodes.Count > 0)
            {
                count = visualNodes[0].ZIndex;
            }
            else
            {
                return 0;
            }

            foreach (VisualNodeViewModel node in visualNodes)
            {
                if (node.ZIndex > count)
                    count = node.ZIndex;
            }

            return count;
        }
    }
}

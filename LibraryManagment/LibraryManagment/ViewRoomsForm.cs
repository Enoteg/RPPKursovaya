using System;
using System.Windows.Forms;
using LibraryManagement.Services;

namespace LibraryManagement
{
    public partial class ViewRoomsForm : Form
    {
        private readonly RoomService _roomService;

        public ViewRoomsForm(RoomService roomService)
        {
            _roomService = roomService ?? throw new ArgumentNullException(nameof(roomService));
            InitializeComponent();
            LoadRooms();
        }

        private void LoadRooms()
        {
            var rooms = _roomService.GetAllRooms();
            roomsListView.Items.Clear();

            foreach (var room in rooms)
            {
                var listItem = new ListViewItem(room.Name);
                listItem.SubItems.Add(room.Specialization);
                listItem.SubItems.Add(room.Capacity.ToString());
                roomsListView.Items.Add(listItem);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

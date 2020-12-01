using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace wpf_practice
{
    /// <summary>
    /// clock.xaml の相互作用ロジック
    /// </summary>
    public partial class clock : Window
    {
        /// <summary>
        /// 時刻表示用タイマー
        /// </summary>
        private DispatcherTimer timer;

        public clock()
        {
            InitializeComponent();

            timer = CreateTimer();

        }

        /// <summary>
        /// タイマー生成処理
        /// </summary>
        /// <returns>生成したタイマー</returns>
        private DispatcherTimer CreateTimer()
        {
            //タイマー生成
            var t = new DispatcherTimer(DispatcherPriority.SystemIdle);

            //タイマーイベントの発生感覚300ミリ秒
            t.Interval = TimeSpan.FromMilliseconds(300);

            //タイマーイベントの定義
            t.Tick += (sender, e) =>
            {
                //タイマーイベント発生時の処理

                //現在の時分秒をテキストに設定
                textBlock.Text = DateTime.Now.ToString("HH:mm:ss");
            };

            return t;
        }

        private void textBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            timer.Start();
        }
    }
}

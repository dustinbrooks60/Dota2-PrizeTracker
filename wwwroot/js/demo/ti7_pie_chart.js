// Set new default font family and font color to mimic Bootstrap's default styling
Chart.defaults.global.defaultFontFamily = 'Nunito', '-apple-system,system-ui,BlinkMacSystemFont,"Segoe UI",Roboto,"Helvetica Neue",Arial,sans-serif';
Chart.defaults.global.defaultFontColor = '#858796';

// Pie Chart Example
var ctx = document.getElementById("TI7PieChart");
var myPieGraph = new Chart(ctx, {
  type: 'pie',
  data: {
    labels: ["1st Place", "2nd Place", "3rd Place", "4th Place", "5th-6th Place", "7th-8th Place", "9th-12th Place", "13th-16th Place", "17th-18th Place"],
    datasets: [{
      data: [10862683, 3950067, 2592231, 1728154, 1110956, 617198, 370319, 123440, 61720],
      backgroundColor: ['#FFD700', '#C0C0C0', '#B08D57', "#b87333", "#B22222", "#8E44AD", "#4e73df", '#1cc88a', '#FFA500'],
      hoverBackgroundColor: [],
      hoverBorderColor: "rgba(234, 236, 244, 1)",
    }],
  },
  options: {
    maintainAspectRatio: false,
    tooltips: {
      backgroundColor: "rgb(255,255,255)",
      bodyFontColor: "#858796",
      borderColor: '#dddfeb',
      borderWidth: 1,
      xPadding: 15,
      yPadding: 15,
      displayColors: false,
      caretPadding: 10,
    },
    legend: {
      display: true,
      position: 'bottom'
    },


  tooltips: {
      callbacks: {
        // this callback is used to create the tooltip label
        label: function(tooltipItem, data) {
          // get the data label and data value to display
          // convert the data value to local string so it uses a comma seperated number
          var dataLabel = data.labels[tooltipItem.index];
          var value = ': ' + '$' + data.datasets[tooltipItem.datasetIndex].data[tooltipItem.index].toLocaleString();

          // make this isn't a multi-line label (e.g. [["label 1 - line 1, "line 2, ], [etc...]])
          if (Chart.helpers.isArray(dataLabel)) {
            // show value on first line of multiline label
            // need to clone because we are changing the value
            dataLabel = dataLabel.slice();
            dataLabel[0] += value;
          } else {
            dataLabel += value;
          }

          // return the text to display on the tooltip
          return dataLabel;
        }
      }
    }

  },
});

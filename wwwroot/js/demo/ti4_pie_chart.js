// Set new default font family and font color to mimic Bootstrap's default styling
Chart.defaults.global.defaultFontFamily = 'Nunito', '-apple-system,system-ui,BlinkMacSystemFont,"Segoe UI",Roboto,"Helvetica Neue",Arial,sans-serif';
Chart.defaults.global.defaultFontColor = '#858796';

// Pie Chart Example
var ctx = document.getElementById("TI4PieChart");
var myPieGraph = new Chart(ctx, {
  type: 'pie',
  data: {
    labels: ["1st Place", "2nd Place", "3rd Place", "4th Place", "5th-6th Place", "7th-8th Place", "9th-10th Place", "11th-12th Place", "13th-14th Place"],
    datasets: [{
      data: [5028308, 1475699, 1038455, 819833, 655866, 519227, 49190, 38259, 21862],
      backgroundColor: ['#FFD700', '#C0C0C0', '#B08D57', "#b87333", "#B22222", "#8E44AD", "#4e73df", "#1cc88a", "#000000"],
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

  },
});
import { Component } from '@angular/core';
import { StockRealTimeService } from './services/real-time/stock-real-time.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'MarketWatchUI';

  constructor(private realTimeService: StockRealTimeService) { }

  ngOnInit(): void {
    this.realTimeService.startConnection();
  }
}

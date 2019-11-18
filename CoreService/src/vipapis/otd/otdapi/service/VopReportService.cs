using System;
using System.Collections.Generic;

namespace vipapis.otd.otdapi.service{
	
	
	public interface VopReportService {
		
		
		com.vip.imp.otd.otdapi.service.VopReportsModel getDailyReports( string advertiser_id_,   com.vip.imp.otd.otdapi.service.VopDeliveryChannelType? channel_,   com.vip.imp.otd.otdapi.service.VopReportLevel? level_,   string start_date_,   string end_date_,   int page_no_,   int page_size_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
	}
	
}
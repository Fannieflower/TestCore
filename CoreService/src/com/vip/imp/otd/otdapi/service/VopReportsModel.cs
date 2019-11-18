using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.imp.otd.otdapi.service{
	
	
	
	
	
	public class VopReportsModel {
		
		///<summary>
		/// 数据报表列表
		///</summary>
		
		private List<com.vip.imp.otd.otdapi.service.VopReportModel> vopReports_;
		
		///<summary>
		/// 分页信息
		///</summary>
		
		private com.vip.imp.otd.otdapi.service.VopPageModel page_;
		
		public List<com.vip.imp.otd.otdapi.service.VopReportModel> GetVopReports(){
			return this.vopReports_;
		}
		
		public void SetVopReports(List<com.vip.imp.otd.otdapi.service.VopReportModel> value){
			this.vopReports_ = value;
		}
		public com.vip.imp.otd.otdapi.service.VopPageModel GetPage(){
			return this.page_;
		}
		
		public void SetPage(com.vip.imp.otd.otdapi.service.VopPageModel value){
			this.page_ = value;
		}
		
	}
	
}
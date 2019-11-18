using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vis.purchase.schedules.service.query{
	
	
	
	
	
	public class QueryScheduleInfoApiParam {
		
		///<summary>
		/// 档期brandId
		///</summary>
		
		private List<long?> brandIdList_;
		
		///<summary>
		/// 采购协议开始时间
		///</summary>
		
		private string sellTimeFrom_;
		
		///<summary>
		/// 采购协议结束时间
		///</summary>
		
		private string sellTimeTo_;
		
		///<summary>
		/// 合作模式
		///</summary>
		
		private List<int?> sellingModeList_;
		
		///<summary>
		/// 是否是常态档期
		///</summary>
		
		private int? normalityFlag_;
		
		///<summary>
		/// 当前页码
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 请求数量
		///</summary>
		
		private int? pageSize_;
		
		public List<long?> GetBrandIdList(){
			return this.brandIdList_;
		}
		
		public void SetBrandIdList(List<long?> value){
			this.brandIdList_ = value;
		}
		public string GetSellTimeFrom(){
			return this.sellTimeFrom_;
		}
		
		public void SetSellTimeFrom(string value){
			this.sellTimeFrom_ = value;
		}
		public string GetSellTimeTo(){
			return this.sellTimeTo_;
		}
		
		public void SetSellTimeTo(string value){
			this.sellTimeTo_ = value;
		}
		public List<int?> GetSellingModeList(){
			return this.sellingModeList_;
		}
		
		public void SetSellingModeList(List<int?> value){
			this.sellingModeList_ = value;
		}
		public int? GetNormalityFlag(){
			return this.normalityFlag_;
		}
		
		public void SetNormalityFlag(int? value){
			this.normalityFlag_ = value;
		}
		public int? GetPage(){
			return this.page_;
		}
		
		public void SetPage(int? value){
			this.page_ = value;
		}
		public int? GetPageSize(){
			return this.pageSize_;
		}
		
		public void SetPageSize(int? value){
			this.pageSize_ = value;
		}
		
	}
	
}
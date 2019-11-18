using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class PrepayInfoRequestModel {
		
		///<summary>
		/// 预付主活动编号
		///</summary>
		
		private string prepayMainNo_;
		
		///<summary>
		/// 已废弃，商品mid列表
		///</summary>
		
		private List<long?> merchandiseIdList_;
		
		///<summary>
		/// 已废弃，预付活动首款开始时间
		///</summary>
		
		private long? firstBeginTime_;
		
		///<summary>
		/// 已废弃，预付活动首款结束时间
		///</summary>
		
		private long? firstEndTime_;
		
		///<summary>
		/// 预付商品信息列表
		///</summary>
		
		private List<com.vip.pms.data.service.PrepayMerchandiseModel> merchandiseModelList_;
		
		///<summary>
		/// 操作类型
		///</summary>
		
		private int? opType_;
		
		public string GetPrepayMainNo(){
			return this.prepayMainNo_;
		}
		
		public void SetPrepayMainNo(string value){
			this.prepayMainNo_ = value;
		}
		public List<long?> GetMerchandiseIdList(){
			return this.merchandiseIdList_;
		}
		
		public void SetMerchandiseIdList(List<long?> value){
			this.merchandiseIdList_ = value;
		}
		public long? GetFirstBeginTime(){
			return this.firstBeginTime_;
		}
		
		public void SetFirstBeginTime(long? value){
			this.firstBeginTime_ = value;
		}
		public long? GetFirstEndTime(){
			return this.firstEndTime_;
		}
		
		public void SetFirstEndTime(long? value){
			this.firstEndTime_ = value;
		}
		public List<com.vip.pms.data.service.PrepayMerchandiseModel> GetMerchandiseModelList(){
			return this.merchandiseModelList_;
		}
		
		public void SetMerchandiseModelList(List<com.vip.pms.data.service.PrepayMerchandiseModel> value){
			this.merchandiseModelList_ = value;
		}
		public int? GetOpType(){
			return this.opType_;
		}
		
		public void SetOpType(int? value){
			this.opType_ = value;
		}
		
	}
	
}
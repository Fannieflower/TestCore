using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class ProtContractDetailModel {
		
		///<summary>
		/// 确认函主体
		///</summary>
		
		private com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoModel mainInfo_;
		
		///<summary>
		/// 确认函活动力度
		///</summary>
		
		private com.vip.api.promotion.vis.protcontract.service.DiscountInfoModel discountInfo_;
		
		///<summary>
		/// 确认函活动审核记录
		///</summary>
		
		private List<com.vip.api.promotion.vis.protcontract.service.ProtContractAuditingLogModel> auditingLogList_;
		
		///<summary>
		/// 确认函活动力度原始数据
		///</summary>
		
		private List<com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoModel> discountList_;
		
		public com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoModel GetMainInfo(){
			return this.mainInfo_;
		}
		
		public void SetMainInfo(com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoModel value){
			this.mainInfo_ = value;
		}
		public com.vip.api.promotion.vis.protcontract.service.DiscountInfoModel GetDiscountInfo(){
			return this.discountInfo_;
		}
		
		public void SetDiscountInfo(com.vip.api.promotion.vis.protcontract.service.DiscountInfoModel value){
			this.discountInfo_ = value;
		}
		public List<com.vip.api.promotion.vis.protcontract.service.ProtContractAuditingLogModel> GetAuditingLogList(){
			return this.auditingLogList_;
		}
		
		public void SetAuditingLogList(List<com.vip.api.promotion.vis.protcontract.service.ProtContractAuditingLogModel> value){
			this.auditingLogList_ = value;
		}
		public List<com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoModel> GetDiscountList(){
			return this.discountList_;
		}
		
		public void SetDiscountList(List<com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoModel> value){
			this.discountList_ = value;
		}
		
	}
	
}
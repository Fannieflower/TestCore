using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class SpecialUserLogRequestModel {
		
		///<summary>
		/// 用户id
		///</summary>
		
		private string userId_;
		
		///<summary>
		/// 定单号order_sn
		///</summary>
		
		private string orderNo_;
		
		///<summary>
		/// 定单原始金额
		///</summary>
		
		private double? orderAmount_;
		
		///<summary>
		/// hash唯一值
		///</summary>
		
		private string orderHash_;
		
		///<summary>
		/// RefInfo列表
		///</summary>
		
		private List<com.vip.pms.data.service.RefInfoModel> refInfoList_;
		
		public string GetUserId(){
			return this.userId_;
		}
		
		public void SetUserId(string value){
			this.userId_ = value;
		}
		public string GetOrderNo(){
			return this.orderNo_;
		}
		
		public void SetOrderNo(string value){
			this.orderNo_ = value;
		}
		public double? GetOrderAmount(){
			return this.orderAmount_;
		}
		
		public void SetOrderAmount(double? value){
			this.orderAmount_ = value;
		}
		public string GetOrderHash(){
			return this.orderHash_;
		}
		
		public void SetOrderHash(string value){
			this.orderHash_ = value;
		}
		public List<com.vip.pms.data.service.RefInfoModel> GetRefInfoList(){
			return this.refInfoList_;
		}
		
		public void SetRefInfoList(List<com.vip.pms.data.service.RefInfoModel> value){
			this.refInfoList_ = value;
		}
		
	}
	
}
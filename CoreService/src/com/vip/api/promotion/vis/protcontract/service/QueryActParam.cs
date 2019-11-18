using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class QueryActParam {
		
		///<summary>
		/// 活动类型（1:满减,2:买免,3:折扣,6:优惠卷红包,7:拼团,8:预付,9:N元任选,10:第N件折扣,11:会员等级专享价,12:人群专享价,13:新老客专享价,14:限时快抢专享价,15:超级VIP专享价,16:加价购,17:单品促销,18:砍价活动）
		///</summary>
		
		private byte? activityType_;
		
		///<summary>
		/// 供应商编码
		///</summary>
		
		private string vendorCode_;
		
		///<summary>
		/// 条件类型（1:根据活动编号精确匹配,2:根据活动名称模糊匹配）
		///</summary>
		
		private byte? queryType_;
		
		///<summary>
		/// 查询字符
		///</summary>
		
		private string q_;
		
		///<summary>
		/// 查询数量限制，默认50
		///</summary>
		
		private int? limit_;
		
		public byte? GetActivityType(){
			return this.activityType_;
		}
		
		public void SetActivityType(byte? value){
			this.activityType_ = value;
		}
		public string GetVendorCode(){
			return this.vendorCode_;
		}
		
		public void SetVendorCode(string value){
			this.vendorCode_ = value;
		}
		public byte? GetQueryType(){
			return this.queryType_;
		}
		
		public void SetQueryType(byte? value){
			this.queryType_ = value;
		}
		public string GetQ(){
			return this.q_;
		}
		
		public void SetQ(string value){
			this.q_ = value;
		}
		public int? GetLimit(){
			return this.limit_;
		}
		
		public void SetLimit(int? value){
			this.limit_ = value;
		}
		
	}
	
}
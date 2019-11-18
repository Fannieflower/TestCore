using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class CouponInfo {
		
		///<summary>
		/// 主信息表
		///</summary>
		
		private long? mainId_;
		
		///<summary>
		/// 活动类型（1:满减,2:买免,3:折扣,6:优惠卷红包,7:拼团,8:预付,9:N元任选,10:第N件折扣,11:会员等级专享价,12:人群专享价,13:新老客专享价,14:限时快抢专享价,15:超级VIP专享价,16:加价购,17:单品促销,18:砍价活动）
		///</summary>
		
		private byte? activityType_;
		
		///<summary>
		/// 优惠券面值
		///</summary>
		
		private string redMoney_;
		
		///<summary>
		/// 优惠券数量
		///</summary>
		
		private int? redNum_;
		
		///<summary>
		/// 满多少元使用
		///</summary>
		
		private string fullMoney_;
		
		///<summary>
		/// 费用承担
		///</summary>
		
		private com.vip.api.promotion.vis.protcontract.service.VendorBearInfo vendorBearInfo_;
		
		public long? GetMainId(){
			return this.mainId_;
		}
		
		public void SetMainId(long? value){
			this.mainId_ = value;
		}
		public byte? GetActivityType(){
			return this.activityType_;
		}
		
		public void SetActivityType(byte? value){
			this.activityType_ = value;
		}
		public string GetRedMoney(){
			return this.redMoney_;
		}
		
		public void SetRedMoney(string value){
			this.redMoney_ = value;
		}
		public int? GetRedNum(){
			return this.redNum_;
		}
		
		public void SetRedNum(int? value){
			this.redNum_ = value;
		}
		public string GetFullMoney(){
			return this.fullMoney_;
		}
		
		public void SetFullMoney(string value){
			this.fullMoney_ = value;
		}
		public com.vip.api.promotion.vis.protcontract.service.VendorBearInfo GetVendorBearInfo(){
			return this.vendorBearInfo_;
		}
		
		public void SetVendorBearInfo(com.vip.api.promotion.vis.protcontract.service.VendorBearInfo value){
			this.vendorBearInfo_ = value;
		}
		
	}
	
}
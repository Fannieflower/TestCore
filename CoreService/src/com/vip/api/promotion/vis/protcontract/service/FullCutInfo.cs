using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class FullCutInfo {
		
		///<summary>
		/// 主信息表
		///</summary>
		
		private long? mainId_;
		
		///<summary>
		/// 活动类型（1:满减,2:买免,3:折扣,6:优惠卷红包,7:拼团,8:预付,9:N元任选,10:第N件折扣,11:会员等级专享价,12:人群专享价,13:新老客专享价,14:限时快抢专享价,15:超级VIP专享价,16:加价购,17:单品促销,18:砍价活动）
		///</summary>
		
		private byte? activityType_;
		
		///<summary>
		/// 活动类型子类型,0：未知，1：A，2：B
		///</summary>
		
		private byte? activityChildType_;
		
		///<summary>
		/// 是否封顶,0:不封顶,1:封顶(满减类)
		///</summary>
		
		private byte? isTop_;
		
		///<summary>
		/// 满减阶梯
		///</summary>
		
		private List<com.vip.api.promotion.vis.protcontract.service.BuyAndCutInfo> buyCuts_;
		
		///<summary>
		/// 活动力度文字描述
		///</summary>
		
		private string discountContent_;
		
		///<summary>
		/// 成团人数
		///</summary>
		
		private int? spellPersonNum_;
		
		///<summary>
		/// 拼团活动优惠类型:1、满减金额 2、满减折扣
		///</summary>
		
		private byte? spellType_;
		
		///<summary>
		/// 拼团活动优惠金额或折扣
		///</summary>
		
		private string spellPreferentialValue_;
		
		///<summary>
		/// 封顶数量
		///</summary>
		
		private int? topNum_;
		
		///<summary>
		/// 费用承担
		///</summary>
		
		private com.vip.api.promotion.vis.protcontract.service.VendorBearInfo vendorBearInfo_;
		
		///<summary>
		/// 活动编号
		///</summary>
		
		private string actNo_;
		
		///<summary>
		/// 活动名称
		///</summary>
		
		private string actName_;
		
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
		public byte? GetActivityChildType(){
			return this.activityChildType_;
		}
		
		public void SetActivityChildType(byte? value){
			this.activityChildType_ = value;
		}
		public byte? GetIsTop(){
			return this.isTop_;
		}
		
		public void SetIsTop(byte? value){
			this.isTop_ = value;
		}
		public List<com.vip.api.promotion.vis.protcontract.service.BuyAndCutInfo> GetBuyCuts(){
			return this.buyCuts_;
		}
		
		public void SetBuyCuts(List<com.vip.api.promotion.vis.protcontract.service.BuyAndCutInfo> value){
			this.buyCuts_ = value;
		}
		public string GetDiscountContent(){
			return this.discountContent_;
		}
		
		public void SetDiscountContent(string value){
			this.discountContent_ = value;
		}
		public int? GetSpellPersonNum(){
			return this.spellPersonNum_;
		}
		
		public void SetSpellPersonNum(int? value){
			this.spellPersonNum_ = value;
		}
		public byte? GetSpellType(){
			return this.spellType_;
		}
		
		public void SetSpellType(byte? value){
			this.spellType_ = value;
		}
		public string GetSpellPreferentialValue(){
			return this.spellPreferentialValue_;
		}
		
		public void SetSpellPreferentialValue(string value){
			this.spellPreferentialValue_ = value;
		}
		public int? GetTopNum(){
			return this.topNum_;
		}
		
		public void SetTopNum(int? value){
			this.topNum_ = value;
		}
		public com.vip.api.promotion.vis.protcontract.service.VendorBearInfo GetVendorBearInfo(){
			return this.vendorBearInfo_;
		}
		
		public void SetVendorBearInfo(com.vip.api.promotion.vis.protcontract.service.VendorBearInfo value){
			this.vendorBearInfo_ = value;
		}
		public string GetActNo(){
			return this.actNo_;
		}
		
		public void SetActNo(string value){
			this.actNo_ = value;
		}
		public string GetActName(){
			return this.actName_;
		}
		
		public void SetActName(string value){
			this.actName_ = value;
		}
		
	}
	
}
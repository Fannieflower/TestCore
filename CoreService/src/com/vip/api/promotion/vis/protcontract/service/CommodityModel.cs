using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class CommodityModel {
		
		///<summary>
		/// 商品ID
		///</summary>
		
		private string mid_;
		
		///<summary>
		/// 货号
		///</summary>
		
		private string commodityNo_;
		
		///<summary>
		/// 条形码
		///</summary>
		
		private string barCode_;
		
		///<summary>
		/// 商品名称
		///</summary>
		
		private string commodityName_;
		
		///<summary>
		/// 专场ID
		///</summary>
		
		private string brandId_;
		
		///<summary>
		/// 优惠类型(拼团)
		///</summary>
		
		private string spellTypeDesc_;
		
		///<summary>
		/// 优惠力度(拼团)
		///</summary>
		
		private string spellTypeFullDesc_;
		
		///<summary>
		/// 成团人数(拼团)
		///</summary>
		
		private int? spellPersonNum_;
		
		///<summary>
		/// 组团限制(拼团)
		///</summary>
		
		private int? spellNumLimit_;
		
		///<summary>
		/// 优惠类型(预付,限时快抢)
		///</summary>
		
		private string preferentialTypeDesc_;
		
		///<summary>
		/// 优惠力度(预付)
		///</summary>
		
		private string prepayPreferential_;
		
		///<summary>
		/// 定金类型(预付)
		///</summary>
		
		private string prepayTypeDesc_;
		
		///<summary>
		/// 定金金额(预付)
		///</summary>
		
		private string prepayValue_;
		
		///<summary>
		/// 优惠力度(限时快抢)
		///</summary>
		
		private string discountValue_;
		
		///<summary>
		/// 活动价
		///</summary>
		
		private string actPrice_;
		
		///<summary>
		/// 帮砍价人数
		///</summary>
		
		private string userHelpCount_;
		
		///<summary>
		/// 底价
		///</summary>
		
		private string floorPrice_;
		
		public string GetMid(){
			return this.mid_;
		}
		
		public void SetMid(string value){
			this.mid_ = value;
		}
		public string GetCommodityNo(){
			return this.commodityNo_;
		}
		
		public void SetCommodityNo(string value){
			this.commodityNo_ = value;
		}
		public string GetBarCode(){
			return this.barCode_;
		}
		
		public void SetBarCode(string value){
			this.barCode_ = value;
		}
		public string GetCommodityName(){
			return this.commodityName_;
		}
		
		public void SetCommodityName(string value){
			this.commodityName_ = value;
		}
		public string GetBrandId(){
			return this.brandId_;
		}
		
		public void SetBrandId(string value){
			this.brandId_ = value;
		}
		public string GetSpellTypeDesc(){
			return this.spellTypeDesc_;
		}
		
		public void SetSpellTypeDesc(string value){
			this.spellTypeDesc_ = value;
		}
		public string GetSpellTypeFullDesc(){
			return this.spellTypeFullDesc_;
		}
		
		public void SetSpellTypeFullDesc(string value){
			this.spellTypeFullDesc_ = value;
		}
		public int? GetSpellPersonNum(){
			return this.spellPersonNum_;
		}
		
		public void SetSpellPersonNum(int? value){
			this.spellPersonNum_ = value;
		}
		public int? GetSpellNumLimit(){
			return this.spellNumLimit_;
		}
		
		public void SetSpellNumLimit(int? value){
			this.spellNumLimit_ = value;
		}
		public string GetPreferentialTypeDesc(){
			return this.preferentialTypeDesc_;
		}
		
		public void SetPreferentialTypeDesc(string value){
			this.preferentialTypeDesc_ = value;
		}
		public string GetPrepayPreferential(){
			return this.prepayPreferential_;
		}
		
		public void SetPrepayPreferential(string value){
			this.prepayPreferential_ = value;
		}
		public string GetPrepayTypeDesc(){
			return this.prepayTypeDesc_;
		}
		
		public void SetPrepayTypeDesc(string value){
			this.prepayTypeDesc_ = value;
		}
		public string GetPrepayValue(){
			return this.prepayValue_;
		}
		
		public void SetPrepayValue(string value){
			this.prepayValue_ = value;
		}
		public string GetDiscountValue(){
			return this.discountValue_;
		}
		
		public void SetDiscountValue(string value){
			this.discountValue_ = value;
		}
		public string GetActPrice(){
			return this.actPrice_;
		}
		
		public void SetActPrice(string value){
			this.actPrice_ = value;
		}
		public string GetUserHelpCount(){
			return this.userHelpCount_;
		}
		
		public void SetUserHelpCount(string value){
			this.userHelpCount_ = value;
		}
		public string GetFloorPrice(){
			return this.floorPrice_;
		}
		
		public void SetFloorPrice(string value){
			this.floorPrice_ = value;
		}
		
	}
	
}
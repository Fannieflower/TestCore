using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class ProtContractDiscountInfoParams {
		
		///<summary>
		/// 主键
		///</summary>
		
		private long? id_;
		
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
		/// 1.满多少(满减类)--已废弃
		///</summary>
		
		private string fullValueOne_;
		
		///<summary>
		/// 1.减多少(满减类)--已废弃
		///</summary>
		
		private string cutsValueOne_;
		
		///<summary>
		/// 2.满多少(满减类)--已废弃
		///</summary>
		
		private string fullValueTwo_;
		
		///<summary>
		/// 2.减多少(满减类)--已废弃
		///</summary>
		
		private string cutsValueTwo_;
		
		///<summary>
		/// 是否封顶,0:不封顶,1:封顶(满减类)
		///</summary>
		
		private byte? isTop_;
		
		///<summary>
		/// 移动端描述(移动专享)
		///</summary>
		
		private string mobileRemark_;
		
		///<summary>
		/// 满多少(优惠卷红包)
		///</summary>
		
		private string redMoney_;
		
		///<summary>
		/// 红包个数
		///</summary>
		
		private int? redNum_;
		
		///<summary>
		/// 满多少元
		///</summary>
		
		private string fullMoney_;
		
		///<summary>
		/// 比例
		///</summary>
		
		private string scaleValue_;
		
		///<summary>
		/// 卷数量
		///</summary>
		
		private int? rollNum_;
		
		///<summary>
		/// 额外返利
		///</summary>
		
		private string extraValue_;
		
		///<summary>
		/// 承担方式,0:未知,1：账扣,2:电汇
		///</summary>
		
		private byte? bearType_;
		
		///<summary>
		/// 承担金额
		///</summary>
		
		private string bearValue_;
		
		///<summary>
		/// 原扣点
		///</summary>
		
		private string oldDeduction_;
		
		///<summary>
		/// 新扣点
		///</summary>
		
		private string newDeduction_;
		
		///<summary>
		/// 3.满多少(满减类)--已废弃
		///</summary>
		
		private string fullValueThree_;
		
		///<summary>
		/// 3.减多少(满减类)--已废弃
		///</summary>
		
		private string cutsValueThree_;
		
		///<summary>
		/// 4.满多少(满减类)--已废弃
		///</summary>
		
		private string fullValueFour_;
		
		///<summary>
		/// 4.减多少(满减类)--已废弃
		///</summary>
		
		private string cutsValueFour_;
		
		///<summary>
		/// 5.满多少(满减类)--已废弃
		///</summary>
		
		private string fullValueFive_;
		
		///<summary>
		/// 5.减多少(满减类)--已废弃
		///</summary>
		
		private string cutsValueFive_;
		
		///<summary>
		/// 优惠类型:1满减,2 折扣,3 定金增值 (此字段预付活动使用)
		///</summary>
		
		private byte? preferentialType_;
		
		///<summary>
		/// 定金类型:1预付固定金额,2预付固定比例
		///</summary>
		
		private byte? prepayType_;
		
		///<summary>
		/// 预付多少(定金增值)
		///</summary>
		
		private string prepayValue_;
		
		///<summary>
		/// 预付优惠或增值多少(定金增值)
		///</summary>
		
		private string prepayPreferential_;
		
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
		/// 专享价列表
		///</summary>
		
		private List<com.vip.api.promotion.vis.common.NameValueItem> exclusivePriceDiscounts_;
		
		///<summary>
		/// 活动编号
		///</summary>
		
		private string actNo_;
		
		///<summary>
		/// 活动名称
		///</summary>
		
		private string actName_;
		
		///<summary>
		/// 满多少减多少
		///</summary>
		
		private List<com.vip.api.promotion.vis.protcontract.service.BuyAndCutInfo> buyAndCutInfos_;
		
		///<summary>
		/// 直发比例
		///</summary>
		
		private string oxoScaleValue_;
		
		public long? GetId(){
			return this.id_;
		}
		
		public void SetId(long? value){
			this.id_ = value;
		}
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
		public string GetFullValueOne(){
			return this.fullValueOne_;
		}
		
		public void SetFullValueOne(string value){
			this.fullValueOne_ = value;
		}
		public string GetCutsValueOne(){
			return this.cutsValueOne_;
		}
		
		public void SetCutsValueOne(string value){
			this.cutsValueOne_ = value;
		}
		public string GetFullValueTwo(){
			return this.fullValueTwo_;
		}
		
		public void SetFullValueTwo(string value){
			this.fullValueTwo_ = value;
		}
		public string GetCutsValueTwo(){
			return this.cutsValueTwo_;
		}
		
		public void SetCutsValueTwo(string value){
			this.cutsValueTwo_ = value;
		}
		public byte? GetIsTop(){
			return this.isTop_;
		}
		
		public void SetIsTop(byte? value){
			this.isTop_ = value;
		}
		public string GetMobileRemark(){
			return this.mobileRemark_;
		}
		
		public void SetMobileRemark(string value){
			this.mobileRemark_ = value;
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
		public string GetScaleValue(){
			return this.scaleValue_;
		}
		
		public void SetScaleValue(string value){
			this.scaleValue_ = value;
		}
		public int? GetRollNum(){
			return this.rollNum_;
		}
		
		public void SetRollNum(int? value){
			this.rollNum_ = value;
		}
		public string GetExtraValue(){
			return this.extraValue_;
		}
		
		public void SetExtraValue(string value){
			this.extraValue_ = value;
		}
		public byte? GetBearType(){
			return this.bearType_;
		}
		
		public void SetBearType(byte? value){
			this.bearType_ = value;
		}
		public string GetBearValue(){
			return this.bearValue_;
		}
		
		public void SetBearValue(string value){
			this.bearValue_ = value;
		}
		public string GetOldDeduction(){
			return this.oldDeduction_;
		}
		
		public void SetOldDeduction(string value){
			this.oldDeduction_ = value;
		}
		public string GetNewDeduction(){
			return this.newDeduction_;
		}
		
		public void SetNewDeduction(string value){
			this.newDeduction_ = value;
		}
		public string GetFullValueThree(){
			return this.fullValueThree_;
		}
		
		public void SetFullValueThree(string value){
			this.fullValueThree_ = value;
		}
		public string GetCutsValueThree(){
			return this.cutsValueThree_;
		}
		
		public void SetCutsValueThree(string value){
			this.cutsValueThree_ = value;
		}
		public string GetFullValueFour(){
			return this.fullValueFour_;
		}
		
		public void SetFullValueFour(string value){
			this.fullValueFour_ = value;
		}
		public string GetCutsValueFour(){
			return this.cutsValueFour_;
		}
		
		public void SetCutsValueFour(string value){
			this.cutsValueFour_ = value;
		}
		public string GetFullValueFive(){
			return this.fullValueFive_;
		}
		
		public void SetFullValueFive(string value){
			this.fullValueFive_ = value;
		}
		public string GetCutsValueFive(){
			return this.cutsValueFive_;
		}
		
		public void SetCutsValueFive(string value){
			this.cutsValueFive_ = value;
		}
		public byte? GetPreferentialType(){
			return this.preferentialType_;
		}
		
		public void SetPreferentialType(byte? value){
			this.preferentialType_ = value;
		}
		public byte? GetPrepayType(){
			return this.prepayType_;
		}
		
		public void SetPrepayType(byte? value){
			this.prepayType_ = value;
		}
		public string GetPrepayValue(){
			return this.prepayValue_;
		}
		
		public void SetPrepayValue(string value){
			this.prepayValue_ = value;
		}
		public string GetPrepayPreferential(){
			return this.prepayPreferential_;
		}
		
		public void SetPrepayPreferential(string value){
			this.prepayPreferential_ = value;
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
		public List<com.vip.api.promotion.vis.common.NameValueItem> GetExclusivePriceDiscounts(){
			return this.exclusivePriceDiscounts_;
		}
		
		public void SetExclusivePriceDiscounts(List<com.vip.api.promotion.vis.common.NameValueItem> value){
			this.exclusivePriceDiscounts_ = value;
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
		public List<com.vip.api.promotion.vis.protcontract.service.BuyAndCutInfo> GetBuyAndCutInfos(){
			return this.buyAndCutInfos_;
		}
		
		public void SetBuyAndCutInfos(List<com.vip.api.promotion.vis.protcontract.service.BuyAndCutInfo> value){
			this.buyAndCutInfos_ = value;
		}
		public string GetOxoScaleValue(){
			return this.oxoScaleValue_;
		}
		
		public void SetOxoScaleValue(string value){
			this.oxoScaleValue_ = value;
		}
		
	}
	
}
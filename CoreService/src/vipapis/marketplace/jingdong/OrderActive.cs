using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.jingdong{
	
	
	
	
	
	public class OrderActive {
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string order_id_;
		
		///<summary>
		/// 活动类型代码：1、买赠；2、满减；3、打折；4、免邮；5、换购；6、买免；7、自由赠；8、虚拟买赠；9、搭配优惠；10、营销送唯品币；11、预付优惠；12、N元任选；14、运费险；15、第N件M折；16、加价购；17、砍价；32、口令满减；33、口令打折；101、PMS优惠券；203、专享价；10001、拼团
		///</summary>
		
		private int? active_type_;
		
		///<summary>
		/// 活动维度代码：1、售卖站点；2、品类；3、档期；4、单品；5、供应商；6、支付优惠；7、PMS优惠券优惠；8、在线支付优惠
		///</summary>
		
		private int? active_field_;
		
		///<summary>
		/// 活动编号
		///</summary>
		
		private string active_no_;
		
		///<summary>
		/// 活动优惠金额
		///</summary>
		
		private string active_discount_money_;
		
		///<summary>
		/// 商品优惠明细
		///</summary>
		
		private List<vipapis.marketplace.jingdong.GoodsDiscountDetail> goods_discount_details_;
		
		///<summary>
		/// 使用优惠券明细
		///</summary>
		
		private List<vipapis.marketplace.jingdong.PromCouponInfo> prom_coupons_;
		
		public string GetOrder_id(){
			return this.order_id_;
		}
		
		public void SetOrder_id(string value){
			this.order_id_ = value;
		}
		public int? GetActive_type(){
			return this.active_type_;
		}
		
		public void SetActive_type(int? value){
			this.active_type_ = value;
		}
		public int? GetActive_field(){
			return this.active_field_;
		}
		
		public void SetActive_field(int? value){
			this.active_field_ = value;
		}
		public string GetActive_no(){
			return this.active_no_;
		}
		
		public void SetActive_no(string value){
			this.active_no_ = value;
		}
		public string GetActive_discount_money(){
			return this.active_discount_money_;
		}
		
		public void SetActive_discount_money(string value){
			this.active_discount_money_ = value;
		}
		public List<vipapis.marketplace.jingdong.GoodsDiscountDetail> GetGoods_discount_details(){
			return this.goods_discount_details_;
		}
		
		public void SetGoods_discount_details(List<vipapis.marketplace.jingdong.GoodsDiscountDetail> value){
			this.goods_discount_details_ = value;
		}
		public List<vipapis.marketplace.jingdong.PromCouponInfo> GetProm_coupons(){
			return this.prom_coupons_;
		}
		
		public void SetProm_coupons(List<vipapis.marketplace.jingdong.PromCouponInfo> value){
			this.prom_coupons_ = value;
		}
		
	}
	
}
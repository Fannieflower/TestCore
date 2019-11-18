using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.asc{
	
	
	
	
	
	public class RefundInfo {
		
		///<summary>
		/// 退款商品总金额 （退款商品总金额=单价*数量）
		///</summary>
		
		private double? return_goods_money_;
		
		///<summary>
		/// 商品优惠金额
		///</summary>
		
		private double? return_goods_fav_;
		
		///<summary>
		/// 扣寄出运费（客户退货不满足免邮条件，系统扣除10元运费）
		///</summary>
		
		private double? send_carriage_;
		
		///<summary>
		/// 运费补贴（对于符合相关规则的退货，唯品会统一补偿用户10元退货商品回寄运费补贴）
		///</summary>
		
		private double? back_carriage_;
		
		///<summary>
		/// 退唯品币金额（退回客户支付的唯品币金额）
		///</summary>
		
		private double? return_vipmoney_;
		
		///<summary>
		/// 退支付红包金额（退回客户使用的支付红包金额）
		///</summary>
		
		private double? return_redpacket_;
		
		///<summary>
		/// 退支付款金额（退回至唯品支付或者微信支付的金额）
		///</summary>
		
		private double? return_amount_;
		
		///<summary>
		/// 退款支付方式（客户使用的支付方式，唯品支付或者微信支付）
		///</summary>
		
		private string return_type_;
		
		///<summary>
		/// 退款总金额 （退款总金额=退支付款金额+退唯品币金额+退支付红包金额。此部分金额未涵盖给客户的运费补贴）
		///</summary>
		
		private double? refund_total_;
		
		public double? GetReturn_goods_money(){
			return this.return_goods_money_;
		}
		
		public void SetReturn_goods_money(double? value){
			this.return_goods_money_ = value;
		}
		public double? GetReturn_goods_fav(){
			return this.return_goods_fav_;
		}
		
		public void SetReturn_goods_fav(double? value){
			this.return_goods_fav_ = value;
		}
		public double? GetSend_carriage(){
			return this.send_carriage_;
		}
		
		public void SetSend_carriage(double? value){
			this.send_carriage_ = value;
		}
		public double? GetBack_carriage(){
			return this.back_carriage_;
		}
		
		public void SetBack_carriage(double? value){
			this.back_carriage_ = value;
		}
		public double? GetReturn_vipmoney(){
			return this.return_vipmoney_;
		}
		
		public void SetReturn_vipmoney(double? value){
			this.return_vipmoney_ = value;
		}
		public double? GetReturn_redpacket(){
			return this.return_redpacket_;
		}
		
		public void SetReturn_redpacket(double? value){
			this.return_redpacket_ = value;
		}
		public double? GetReturn_amount(){
			return this.return_amount_;
		}
		
		public void SetReturn_amount(double? value){
			this.return_amount_ = value;
		}
		public string GetReturn_type(){
			return this.return_type_;
		}
		
		public void SetReturn_type(string value){
			this.return_type_ = value;
		}
		public double? GetRefund_total(){
			return this.refund_total_;
		}
		
		public void SetRefund_total(double? value){
			this.refund_total_ = value;
		}
		
	}
	
}
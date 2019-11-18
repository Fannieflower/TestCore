using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.jitx{
	
	
	
	
	
	public class BellePrintDetail {
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string order_sn_;
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string transport_no_;
		
		///<summary>
		/// 订单当前包裹序号
		///</summary>
		
		private int? box_no_;
		
		///<summary>
		/// 承运商编码
		///</summary>
		
		private string carrier_code_;
		
		///<summary>
		/// 订单包裹总数
		///</summary>
		
		private int? total_package_;
		
		///<summary>
		/// 商品明细;如List大小为2，则分两行展示<br>69012584663246*红色*XL*1<br>69012584663246*蓝色*XL*1
		///</summary>
		
		private List<string> goods_info_;
		
		///<summary>
		/// 发货仓库编码
		///</summary>
		
		private string delivery_warehouse_code_;
		
		public string GetOrder_sn(){
			return this.order_sn_;
		}
		
		public void SetOrder_sn(string value){
			this.order_sn_ = value;
		}
		public string GetTransport_no(){
			return this.transport_no_;
		}
		
		public void SetTransport_no(string value){
			this.transport_no_ = value;
		}
		public int? GetBox_no(){
			return this.box_no_;
		}
		
		public void SetBox_no(int? value){
			this.box_no_ = value;
		}
		public string GetCarrier_code(){
			return this.carrier_code_;
		}
		
		public void SetCarrier_code(string value){
			this.carrier_code_ = value;
		}
		public int? GetTotal_package(){
			return this.total_package_;
		}
		
		public void SetTotal_package(int? value){
			this.total_package_ = value;
		}
		public List<string> GetGoods_info(){
			return this.goods_info_;
		}
		
		public void SetGoods_info(List<string> value){
			this.goods_info_ = value;
		}
		public string GetDelivery_warehouse_code(){
			return this.delivery_warehouse_code_;
		}
		
		public void SetDelivery_warehouse_code(string value){
			this.delivery_warehouse_code_ = value;
		}
		
	}
	
}
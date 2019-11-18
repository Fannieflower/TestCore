using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.transferring.api{
	
	
	
	
	
	public class TransferringOrderApiModel {
		
		///<summary>
		/// 线下店主体：xstorebuy、maxxbuy
		///</summary>
		
		private string company_code_;
		
		///<summary>
		/// 中台调拨单号
		///</summary>
		
		private string transferring_order_no_;
		
		///<summary>
		/// 调拨类型，1:大仓-门店；2:门店-大仓；3:门店-门店
		///</summary>
		
		private byte? transferring_type_;
		
		///<summary>
		/// 发货店仓代码
		///</summary>
		
		private string src_warehouse_code_;
		
		///<summary>
		/// 收货店仓代码
		///</summary>
		
		private string dest_warehouse_code_;
		
		///<summary>
		/// 创建人ID
		///</summary>
		
		private string created_by_user_id_;
		
		///<summary>
		/// 是否鲸仓，0-非鲸仓，1-鲸仓
		///</summary>
		
		private byte? is_whale_warehouse_;
		
		///<summary>
		/// 单据审核日期，时分秒
		///</summary>
		
		private System.DateTime? create_time_;
		
		///<summary>
		/// 预计到货时间
		///</summary>
		
		private System.DateTime? estimated_arrival_time_;
		
		///<summary>
		/// 是否实物发货
		///</summary>
		
		private byte? pre_created_;
		
		public string GetCompany_code(){
			return this.company_code_;
		}
		
		public void SetCompany_code(string value){
			this.company_code_ = value;
		}
		public string GetTransferring_order_no(){
			return this.transferring_order_no_;
		}
		
		public void SetTransferring_order_no(string value){
			this.transferring_order_no_ = value;
		}
		public byte? GetTransferring_type(){
			return this.transferring_type_;
		}
		
		public void SetTransferring_type(byte? value){
			this.transferring_type_ = value;
		}
		public string GetSrc_warehouse_code(){
			return this.src_warehouse_code_;
		}
		
		public void SetSrc_warehouse_code(string value){
			this.src_warehouse_code_ = value;
		}
		public string GetDest_warehouse_code(){
			return this.dest_warehouse_code_;
		}
		
		public void SetDest_warehouse_code(string value){
			this.dest_warehouse_code_ = value;
		}
		public string GetCreated_by_user_id(){
			return this.created_by_user_id_;
		}
		
		public void SetCreated_by_user_id(string value){
			this.created_by_user_id_ = value;
		}
		public byte? GetIs_whale_warehouse(){
			return this.is_whale_warehouse_;
		}
		
		public void SetIs_whale_warehouse(byte? value){
			this.is_whale_warehouse_ = value;
		}
		public System.DateTime? GetCreate_time(){
			return this.create_time_;
		}
		
		public void SetCreate_time(System.DateTime? value){
			this.create_time_ = value;
		}
		public System.DateTime? GetEstimated_arrival_time(){
			return this.estimated_arrival_time_;
		}
		
		public void SetEstimated_arrival_time(System.DateTime? value){
			this.estimated_arrival_time_ = value;
		}
		public byte? GetPre_created(){
			return this.pre_created_;
		}
		
		public void SetPre_created(byte? value){
			this.pre_created_ = value;
		}
		
	}
	
}
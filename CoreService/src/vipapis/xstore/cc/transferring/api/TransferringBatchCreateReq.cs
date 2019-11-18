using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.transferring.api{
	
	
	
	
	
	public class TransferringBatchCreateReq {
		
		///<summary>
		/// 调拨类型, 2:店店调拨,3:店仓调拨
		///</summary>
		
		private byte? transferring_type_;
		
		///<summary>
		/// 外部调拨单号(ERP创建时使用ERP单号)
		///</summary>
		
		private string ext_trans_order_no_;
		
		///<summary>
		/// 来源主体代码
		///</summary>
		
		private string src_company_code_;
		
		///<summary>
		/// 来源仓库代码
		///</summary>
		
		private string src_warehouse_code_;
		
		///<summary>
		/// 目的主体代码
		///</summary>
		
		private string dest_company_code_;
		
		///<summary>
		/// 目的仓库代码
		///</summary>
		
		private string dest_warehouse_code_;
		
		///<summary>
		/// 是否鲸仓
		///</summary>
		
		private byte? is_whale_warehouse_;
		
		///<summary>
		/// 备注
		///</summary>
		
		private string remark_;
		
		///<summary>
		/// 预计到货时间
		///</summary>
		
		private System.DateTime? estimated_arrival_time_;
		
		public byte? GetTransferring_type(){
			return this.transferring_type_;
		}
		
		public void SetTransferring_type(byte? value){
			this.transferring_type_ = value;
		}
		public string GetExt_trans_order_no(){
			return this.ext_trans_order_no_;
		}
		
		public void SetExt_trans_order_no(string value){
			this.ext_trans_order_no_ = value;
		}
		public string GetSrc_company_code(){
			return this.src_company_code_;
		}
		
		public void SetSrc_company_code(string value){
			this.src_company_code_ = value;
		}
		public string GetSrc_warehouse_code(){
			return this.src_warehouse_code_;
		}
		
		public void SetSrc_warehouse_code(string value){
			this.src_warehouse_code_ = value;
		}
		public string GetDest_company_code(){
			return this.dest_company_code_;
		}
		
		public void SetDest_company_code(string value){
			this.dest_company_code_ = value;
		}
		public string GetDest_warehouse_code(){
			return this.dest_warehouse_code_;
		}
		
		public void SetDest_warehouse_code(string value){
			this.dest_warehouse_code_ = value;
		}
		public byte? GetIs_whale_warehouse(){
			return this.is_whale_warehouse_;
		}
		
		public void SetIs_whale_warehouse(byte? value){
			this.is_whale_warehouse_ = value;
		}
		public string GetRemark(){
			return this.remark_;
		}
		
		public void SetRemark(string value){
			this.remark_ = value;
		}
		public System.DateTime? GetEstimated_arrival_time(){
			return this.estimated_arrival_time_;
		}
		
		public void SetEstimated_arrival_time(System.DateTime? value){
			this.estimated_arrival_time_ = value;
		}
		
	}
	
}
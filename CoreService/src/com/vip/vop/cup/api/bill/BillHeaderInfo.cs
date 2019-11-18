using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.bill{
	
	
	
	
	
	public class BillHeaderInfo {
		
		///<summary>
		/// 账单号
		///</summary>
		
		private string bill_no_;
		
		///<summary>
		/// 合作模式(渠道分销模式)：佣金/供货价
		///</summary>
		
		private string channel_coop_mode_;
		
		///<summary>
		/// 发起方，账单生成来源
		///</summary>
		
		private string sponsor_;
		
		///<summary>
		/// 帐单总金额(2位小数)
		///</summary>
		
		private string bill_amount_;
		
		///<summary>
		/// 账单总明细行数
		///</summary>
		
		private int? bill_detail_count_;
		
		///<summary>
		/// 账单传输完成状态 N:未完成 S:完成
		///</summary>
		
		private string finish_flag_;
		
		///<summary>
		/// 账单详细信息列表
		///</summary>
		
		private List<com.vip.vop.cup.api.bill.BillDetailInfo> bill_detail_info_list_;
		
		public string GetBill_no(){
			return this.bill_no_;
		}
		
		public void SetBill_no(string value){
			this.bill_no_ = value;
		}
		public string GetChannel_coop_mode(){
			return this.channel_coop_mode_;
		}
		
		public void SetChannel_coop_mode(string value){
			this.channel_coop_mode_ = value;
		}
		public string GetSponsor(){
			return this.sponsor_;
		}
		
		public void SetSponsor(string value){
			this.sponsor_ = value;
		}
		public string GetBill_amount(){
			return this.bill_amount_;
		}
		
		public void SetBill_amount(string value){
			this.bill_amount_ = value;
		}
		public int? GetBill_detail_count(){
			return this.bill_detail_count_;
		}
		
		public void SetBill_detail_count(int? value){
			this.bill_detail_count_ = value;
		}
		public string GetFinish_flag(){
			return this.finish_flag_;
		}
		
		public void SetFinish_flag(string value){
			this.finish_flag_ = value;
		}
		public List<com.vip.vop.cup.api.bill.BillDetailInfo> GetBill_detail_info_list(){
			return this.bill_detail_info_list_;
		}
		
		public void SetBill_detail_info_list(List<com.vip.vop.cup.api.bill.BillDetailInfo> value){
			this.bill_detail_info_list_ = value;
		}
		
	}
	
}
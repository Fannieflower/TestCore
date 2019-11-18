using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.asc{
	
	
	
	
	
	public class AscBrief {
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string order_id_;
		
		///<summary>
		/// 售后申请单号
		///</summary>
		
		private string asc_sn_;
		
		///<summary>
		/// 售后申请单类型： 0拒收，1客退
		///</summary>
		
		private byte? asc_type_;
		
		///<summary>
		/// 售后申请单的申请时间
		///</summary>
		
		private string asc_time_;
		
		///<summary>
		/// 售后申请单状态：0 待审核，1 已审核，2 审核不通过，3 已同意退款，4 已拒绝退款，9 已完成，10 已取消
		///</summary>
		
		private string asc_status_;
		
		///<summary>
		/// 退款状态：1 未发起退款 2 已发起退款 99 无需退款
		///</summary>
		
		private string refund_status_;
		
		///<summary>
		/// 用户填写的备注
		///</summary>
		
		private string user_remark_;
		
		///<summary>
		/// 用户上传的图片地址
		///</summary>
		
		private List<string> image_urls_;
		
		///<summary>
		/// 用户id。暂时为空，后期扩展使用。
		///</summary>
		
		private string open_id_;
		
		public string GetOrder_id(){
			return this.order_id_;
		}
		
		public void SetOrder_id(string value){
			this.order_id_ = value;
		}
		public string GetAsc_sn(){
			return this.asc_sn_;
		}
		
		public void SetAsc_sn(string value){
			this.asc_sn_ = value;
		}
		public byte? GetAsc_type(){
			return this.asc_type_;
		}
		
		public void SetAsc_type(byte? value){
			this.asc_type_ = value;
		}
		public string GetAsc_time(){
			return this.asc_time_;
		}
		
		public void SetAsc_time(string value){
			this.asc_time_ = value;
		}
		public string GetAsc_status(){
			return this.asc_status_;
		}
		
		public void SetAsc_status(string value){
			this.asc_status_ = value;
		}
		public string GetRefund_status(){
			return this.refund_status_;
		}
		
		public void SetRefund_status(string value){
			this.refund_status_ = value;
		}
		public string GetUser_remark(){
			return this.user_remark_;
		}
		
		public void SetUser_remark(string value){
			this.user_remark_ = value;
		}
		public List<string> GetImage_urls(){
			return this.image_urls_;
		}
		
		public void SetImage_urls(List<string> value){
			this.image_urls_ = value;
		}
		public string GetOpen_id(){
			return this.open_id_;
		}
		
		public void SetOpen_id(string value){
			this.open_id_ = value;
		}
		
	}
	
}
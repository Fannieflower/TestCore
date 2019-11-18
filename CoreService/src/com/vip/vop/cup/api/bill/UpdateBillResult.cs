using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.bill{
	
	
	
	
	
	public class UpdateBillResult {
		
		///<summary>
		/// 处理成功channelDataId集合
		///</summary>
		
		private List<long?> success_channel_data_id_list_;
		
		///<summary>
		/// 处理失败channelDataId集合
		///</summary>
		
		private List<long?> failure_channel_data_id_list_;
		
		///<summary>
		/// 处理失败channelDataId对应的错误原因集合
		///</summary>
		
		private List<string> failure_msg_list_;
		
		public List<long?> GetSuccess_channel_data_id_list(){
			return this.success_channel_data_id_list_;
		}
		
		public void SetSuccess_channel_data_id_list(List<long?> value){
			this.success_channel_data_id_list_ = value;
		}
		public List<long?> GetFailure_channel_data_id_list(){
			return this.failure_channel_data_id_list_;
		}
		
		public void SetFailure_channel_data_id_list(List<long?> value){
			this.failure_channel_data_id_list_ = value;
		}
		public List<string> GetFailure_msg_list(){
			return this.failure_msg_list_;
		}
		
		public void SetFailure_msg_list(List<string> value){
			this.failure_msg_list_ = value;
		}
		
	}
	
}
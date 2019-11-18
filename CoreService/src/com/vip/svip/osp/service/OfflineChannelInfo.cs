using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class OfflineChannelInfo {
		
		///<summary>
		/// 线下渠道类型 1 线下导购；2校园卡
		///</summary>
		
		private int? channelType_;
		
		///<summary>
		/// 导购员标识（渠道类型为线下导购时有效）
		///</summary>
		
		private string guideName_;
		
		public int? GetChannelType(){
			return this.channelType_;
		}
		
		public void SetChannelType(int? value){
			this.channelType_ = value;
		}
		public string GetGuideName(){
			return this.guideName_;
		}
		
		public void SetGuideName(string value){
			this.guideName_ = value;
		}
		
	}
	
}
using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class CommandRequestModel {
		
		///<summary>
		/// 口令红包核心参数
		///</summary>
		
		private com.vip.pms.data.service.PmsCommandCoreModel commandCoreModel_;
		
		public com.vip.pms.data.service.PmsCommandCoreModel GetCommandCoreModel(){
			return this.commandCoreModel_;
		}
		
		public void SetCommandCoreModel(com.vip.pms.data.service.PmsCommandCoreModel value){
			this.commandCoreModel_ = value;
		}
		
	}
	
}
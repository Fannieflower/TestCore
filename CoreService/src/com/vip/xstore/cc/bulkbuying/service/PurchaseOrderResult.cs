using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	
	
	
	public class PurchaseOrderResult {
		
		///<summary>
		/// 上传到文件服务器的导出地址
		///</summary>
		
		private string exportFilePath_;
		
		public string GetExportFilePath(){
			return this.exportFilePath_;
		}
		
		public void SetExportFilePath(string value){
			this.exportFilePath_ = value;
		}
		
	}
	
}
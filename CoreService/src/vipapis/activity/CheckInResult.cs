using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.activity{
	
	
	
	
	
	public class CheckInResult {
		
		///<summary>
		/// 状态码：0: 失败(其他无说明错误都归0; 1: 成功；<br> -1: 参数异常；-3：活动不存在<br> 110001:仅限内网访问；120001：无权限调用该资源；<br>120002:PMS活动编号为空; 195001: 中间层错误,具体请看CouponData节点错误描述
		///</summary>
		
		private string status_;
		
		///<summary>
		/// 返回描述
		///</summary>
		
		private string msg_;
		
		///<summary>
		/// 领券数据
		///</summary>
		
		private vipapis.activity.CouponData data_;
		
		public string GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(string value){
			this.status_ = value;
		}
		public string GetMsg(){
			return this.msg_;
		}
		
		public void SetMsg(string value){
			this.msg_ = value;
		}
		public vipapis.activity.CouponData GetData(){
			return this.data_;
		}
		
		public void SetData(vipapis.activity.CouponData value){
			this.data_ = value;
		}
		
	}
	
}
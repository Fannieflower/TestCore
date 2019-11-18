using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.product{
	
	
	
	
	
	public class Host {
		
		///<summary>
		/// 合作伙伴id
		///</summary>
		
		private string partnerId_;
		
		///<summary>
		/// 主机类型
		///</summary>
		
		private byte? hostType_;
		
		///<summary>
		/// 主机名
		///</summary>
		
		private string host_;
		
		///<summary>
		/// 端口号
		///</summary>
		
		private int? port_;
		
		///<summary>
		/// 用户名
		///</summary>
		
		private string username_;
		
		///<summary>
		/// 用户密码
		///</summary>
		
		private string password_;
		
		///<summary>
		/// 主键id
		///</summary>
		
		private long? id_;
		
		public string GetPartnerId(){
			return this.partnerId_;
		}
		
		public void SetPartnerId(string value){
			this.partnerId_ = value;
		}
		public byte? GetHostType(){
			return this.hostType_;
		}
		
		public void SetHostType(byte? value){
			this.hostType_ = value;
		}
		public string GetHost(){
			return this.host_;
		}
		
		public void SetHost(string value){
			this.host_ = value;
		}
		public int? GetPort(){
			return this.port_;
		}
		
		public void SetPort(int? value){
			this.port_ = value;
		}
		public string GetUsername(){
			return this.username_;
		}
		
		public void SetUsername(string value){
			this.username_ = value;
		}
		public string GetPassword(){
			return this.password_;
		}
		
		public void SetPassword(string value){
			this.password_ = value;
		}
		public long? GetId(){
			return this.id_;
		}
		
		public void SetId(long? value){
			this.id_ = value;
		}
		
	}
	
}
using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.vcloud.order{
	
	
	
	public class OrderOptLogHelper : TBeanSerializer<OrderOptLog>
	{
		
		public static OrderOptLogHelper OBJ = new OrderOptLogHelper();
		
		public static OrderOptLogHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OrderOptLog structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("status".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetStatus(value);
					}
					
					
					
					
					
					if ("account".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAccount(value);
					}
					
					
					
					
					
					if ("optTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetOptTime(value);
					}
					
					
					
					
					
					if ("operate".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOperate(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(OrderOptLog structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetStatus() != null) {
				
				oprot.WriteFieldBegin("status");
				oprot.WriteI32((int)structs.GetStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("status can not be null!");
			}
			
			
			if(structs.GetAccount() != null) {
				
				oprot.WriteFieldBegin("account");
				oprot.WriteString(structs.GetAccount());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("account can not be null!");
			}
			
			
			if(structs.GetOptTime() != null) {
				
				oprot.WriteFieldBegin("optTime");
				oprot.WriteI64((long)structs.GetOptTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("optTime can not be null!");
			}
			
			
			if(structs.GetOperate() != null) {
				
				oprot.WriteFieldBegin("operate");
				oprot.WriteString(structs.GetOperate());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("operate can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OrderOptLog bean){
			
			
		}
		
	}
	
}
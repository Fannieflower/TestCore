using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.transferring.api{
	
	
	
	public class TransferringOrderReceivedListHelper : TBeanSerializer<TransferringOrderReceivedList>
	{
		
		public static TransferringOrderReceivedListHelper OBJ = new TransferringOrderReceivedListHelper();
		
		public static TransferringOrderReceivedListHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(TransferringOrderReceivedList structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("company_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCompany_code(value);
					}
					
					
					
					
					
					if ("transferring_order_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransferring_order_no(value);
					}
					
					
					
					
					
					if ("received_warehouse_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReceived_warehouse_code(value);
					}
					
					
					
					
					
					if ("received_date".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetReceived_date(value);
					}
					
					
					
					
					
					if ("transferring_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetTransferring_type(value);
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
		
		
		public void Write(TransferringOrderReceivedList structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCompany_code() != null) {
				
				oprot.WriteFieldBegin("company_code");
				oprot.WriteString(structs.GetCompany_code());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("company_code can not be null!");
			}
			
			
			if(structs.GetTransferring_order_no() != null) {
				
				oprot.WriteFieldBegin("transferring_order_no");
				oprot.WriteString(structs.GetTransferring_order_no());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("transferring_order_no can not be null!");
			}
			
			
			if(structs.GetReceived_warehouse_code() != null) {
				
				oprot.WriteFieldBegin("received_warehouse_code");
				oprot.WriteString(structs.GetReceived_warehouse_code());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("received_warehouse_code can not be null!");
			}
			
			
			if(structs.GetReceived_date() != null) {
				
				oprot.WriteFieldBegin("received_date");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetReceived_date())); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("received_date can not be null!");
			}
			
			
			if(structs.GetTransferring_type() != null) {
				
				oprot.WriteFieldBegin("transferring_type");
				oprot.WriteI32((int)structs.GetTransferring_type()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("transferring_type can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(TransferringOrderReceivedList bean){
			
			
		}
		
	}
	
}
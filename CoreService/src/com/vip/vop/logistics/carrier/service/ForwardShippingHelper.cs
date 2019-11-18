using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.logistics.carrier.service{
	
	
	
	public class ForwardShippingHelper : TBeanSerializer<ForwardShipping>
	{
		
		public static ForwardShippingHelper OBJ = new ForwardShippingHelper();
		
		public static ForwardShippingHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ForwardShipping structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("new_carrier_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetNew_carrier_code(value);
					}
					
					
					
					
					
					if ("new_logistics_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetNew_logistics_no(value);
					}
					
					
					
					
					
					if ("origin_logistics_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrigin_logistics_no(value);
					}
					
					
					
					
					
					if ("receiver".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.vop.logistics.Linkman value;
						
						value = new com.vip.vop.logistics.Linkman();
						com.vip.vop.logistics.LinkmanHelper.getInstance().Read(value, iprot);
						
						structs.SetReceiver(value);
					}
					
					
					
					
					
					if ("receiver_address".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.vop.logistics.Address value;
						
						value = new com.vip.vop.logistics.Address();
						com.vip.vop.logistics.AddressHelper.getInstance().Read(value, iprot);
						
						structs.SetReceiver_address(value);
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
		
		
		public void Write(ForwardShipping structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetNew_carrier_code() != null) {
				
				oprot.WriteFieldBegin("new_carrier_code");
				oprot.WriteString(structs.GetNew_carrier_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetNew_logistics_no() != null) {
				
				oprot.WriteFieldBegin("new_logistics_no");
				oprot.WriteString(structs.GetNew_logistics_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrigin_logistics_no() != null) {
				
				oprot.WriteFieldBegin("origin_logistics_no");
				oprot.WriteString(structs.GetOrigin_logistics_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReceiver() != null) {
				
				oprot.WriteFieldBegin("receiver");
				
				com.vip.vop.logistics.LinkmanHelper.getInstance().Write(structs.GetReceiver(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReceiver_address() != null) {
				
				oprot.WriteFieldBegin("receiver_address");
				
				com.vip.vop.logistics.AddressHelper.getInstance().Write(structs.GetReceiver_address(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ForwardShipping bean){
			
			
		}
		
	}
	
}
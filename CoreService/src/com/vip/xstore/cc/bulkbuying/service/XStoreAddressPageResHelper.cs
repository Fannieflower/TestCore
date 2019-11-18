using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	
	public class XStoreAddressPageResHelper : TBeanSerializer<XStoreAddressPageRes>
	{
		
		public static XStoreAddressPageResHelper OBJ = new XStoreAddressPageResHelper();
		
		public static XStoreAddressPageResHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(XStoreAddressPageRes structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("total".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetTotal(value);
					}
					
					
					
					
					
					if ("addresses".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel> value;
						
						value = new List<com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel elem0;
								
								elem0 = new com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel();
								com.vip.xstore.cc.bulkbuying.service.XStoreAddressModelHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetAddresses(value);
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
		
		
		public void Write(XStoreAddressPageRes structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTotal() != null) {
				
				oprot.WriteFieldBegin("total");
				oprot.WriteI32((int)structs.GetTotal()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAddresses() != null) {
				
				oprot.WriteFieldBegin("addresses");
				
				oprot.WriteListBegin();
				foreach(com.vip.xstore.cc.bulkbuying.service.XStoreAddressModel _item0 in structs.GetAddresses()){
					
					
					com.vip.xstore.cc.bulkbuying.service.XStoreAddressModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(XStoreAddressPageRes bean){
			
			
		}
		
	}
	
}
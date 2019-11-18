using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.store{
	
	
	
	public class WarehouseStoreResponseHelper : TBeanSerializer<WarehouseStoreResponse>
	{
		
		public static WarehouseStoreResponseHelper OBJ = new WarehouseStoreResponseHelper();
		
		public static WarehouseStoreResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(WarehouseStoreResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("warehouse_store".Equals(schemeField.Trim())){
						
						needSkip = false;
						Dictionary<string, List<vipapis.store.StoreInfo>> value;
						
						value = new Dictionary<string, List<vipapis.store.StoreInfo>>();
						iprot.ReadMapBegin();
						while(true){
							
							try{
								
								string _key0;
								List<vipapis.store.StoreInfo> _val0;
								_key0 = iprot.ReadString();
								
								
								_val0 = new List<vipapis.store.StoreInfo>();
								iprot.ReadListBegin();
								while(true){
									
									try{
										
										vipapis.store.StoreInfo elem1;
										
										elem1 = new vipapis.store.StoreInfo();
										vipapis.store.StoreInfoHelper.getInstance().Read(elem1, iprot);
										
										_val0.Add(elem1);
									}
									catch(Exception e){
										
										
										break;
									}
								}
								
								iprot.ReadListEnd();
								
								value.Add(_key0, _val0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadMapEnd();
						
						structs.SetWarehouse_store(value);
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
		
		
		public void Write(WarehouseStoreResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetWarehouse_store() != null) {
				
				oprot.WriteFieldBegin("warehouse_store");
				
				oprot.WriteMapBegin();
				foreach(KeyValuePair< string, List<vipapis.store.StoreInfo> > _ir0 in structs.GetWarehouse_store()){
					
					string _key0 = _ir0.Key;
					List<vipapis.store.StoreInfo> _value0 = _ir0.Value;
					oprot.WriteString(_key0);
					
					
					oprot.WriteListBegin();
					foreach(vipapis.store.StoreInfo _item1 in _value0){
						
						
						vipapis.store.StoreInfoHelper.getInstance().Write(_item1, oprot);
						
					}
					
					oprot.WriteListEnd();
					
				}
				
				oprot.WriteMapEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("warehouse_store can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(WarehouseStoreResponse bean){
			
			
		}
		
	}
	
}